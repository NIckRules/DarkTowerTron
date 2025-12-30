using UnityEngine;
using System.Collections;
using System.Collections.Generic; // FIX: Added for List<>
using DarkTowerTron.Core.Data;
using DarkTowerTron.AI.FSM;
using DarkTowerTron.Combat;

namespace DarkTowerTron.Enemy.Bosses.Architect
{
    public class ArchitectState_Pattern : State
    {
        // FIX: Reference the Boss Controller, NOT the Guardian Agent
        private ArchitectController _boss;

        private ArchitectPatternSO _currentPattern;
        private float _patternTimer;

        public ArchitectState_Pattern(ArchitectController boss, ArchitectPatternSO pattern)
        {
            _boss = boss;
            _currentPattern = pattern;
        }

        public override void Enter()
        {
            // 1. Apply Rotation
            _boss.SetRotationSpeed(_currentPattern.rotationSpeed);

            // 2. Timer
            _patternTimer = _currentPattern.activeDuration;

            _boss.StartCoroutine(RunPatternSequence());
        }

        // Helper to handle array safety
        private bool GetHandExtend(bool outer)
        {
            // Simple logic: if any in array are true, extend? 
            // Or better: The Controller's SetHandsState iterates the hands and checks the array index.
            // But ArchitectController.SetHandsState currently takes a simple BOOL.
            // Let's stick to simple: If pattern says extend, we extend all.
            // If you want per-hand logic, we need to update Controller.
            // For now: Just check the first element as a master switch
            if (_currentPattern.extendHands != null && _currentPattern.extendHands.Length > 0)
                return _currentPattern.extendHands[0];
            return false;
        }

        private bool GetWallStatus(bool active)
        {
            if (_currentPattern.activateWalls != null && _currentPattern.activateWalls.Length > 0)
                return _currentPattern.activateWalls[0];
            return false;
        }

        public override void LogicUpdate()
        {
            // Boss Core doesn't stagger, so we don't check for it here.

            // Handle Pattern Timer
            _patternTimer -= Time.deltaTime;
            if (_patternTimer <= 0)
            {
                // In a real FSM, we would define what "Next" is.
                // For now, we rely on the Coroutine to transition us back to Idle/Move
            }
        }

        private IEnumerator RunPatternSequence()
        {
            // --- 1. SETUP & TELEGRAPH ---
            bool[] extendConfig = _currentPattern.extendHands;
            bool[] wallConfig = _currentPattern.activateWalls;

            _boss.MoveHands(extendConfig);
            _boss.TelegraphWalls(wallConfig);

            // Wait for Telegraph
            yield return new WaitForSeconds(_currentPattern.startDelay);
            
            // --- 2. ACTIVATE HAZARDS ---
            _boss.ActivateWalls(wallConfig);

            // --- 3. ACTIVE PHASE (Loop for Duration) ---
            float phaseDuration = _currentPattern.activeDuration - _currentPattern.startDelay;
            float timer = 0f;
            
            // vars for shooting
            float shotCooldown = 0f;
            bool hasGun = _currentPattern.shootingPattern != null;

            while (timer < phaseDuration)
            {
                if (_boss.IsStaggered) break; ; // Optional break on stagger

                float dt = Time.deltaTime;
                timer += dt;

                // SHOOTING LOGIC (Running inside the main timer loop)
                if (hasGun)
                {
                    shotCooldown -= dt;
                    if (shotCooldown <= 0)
                    {
                        FireProjectilesFromHands();
                        shotCooldown = _currentPattern.shootingPattern.delayBetweenShots;
                    }
                }

                yield return null;
            }

            // --- 4. CLEANUP ---
            _boss.ResetHands(); // Retracts and turns off walls
            
            yield return new WaitForSeconds(1.0f); // Retract animation buffer

            _boss.OnPatternFinished();
        }

        private void FireProjectilesFromHands()
        {
            // Safety check for shooting pattern
            if (_currentPattern.shootingPattern == null) return;

            AttackPatternSO attackData = _currentPattern.shootingPattern;
            bool useForward = attackData.aimMode == AimType.ForwardRadial;
            float scale = attackData.scaleMultiplier;

            // FIX: Use FOR loop to check index against the Config Arrays
            for (int i = 0; i < _boss.hands.Count; i++)
            {
                var hand = _boss.hands[i];
                if (hand == null) continue;

                // CHECK CONFIG: Does this specific hand have permission to shoot?
                bool canShoot = false;
                if (_currentPattern.activeGuns != null && i < _currentPattern.activeGuns.Length)
                {
                    canShoot = _currentPattern.activeGuns[i];
                }

                if (canShoot)
                {
                    Vector3 targetPos = Vector3.zero;
                    if (_boss.GetTarget() != null) targetPos = _boss.GetTarget().position;

                    hand.Shoot(targetPos, useForward, scale);
                }
            }
        }
    }
}