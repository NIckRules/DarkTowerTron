using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Gameplay.Environment
{
    public class ArenaGate : MonoBehaviour, ILockable
    {
        private enum GateState { Open, Closed }

        [Header("References")]
        [Tooltip("Assign the object that should slide (e.g. Wall_Pivot). Do NOT assign the Root.")]
        [SerializeField] private Transform _movingPart;

        [Header("Configuration")]
        [SerializeField] private Vector3 _openLocalPos;
        [SerializeField] private Vector3 _closedLocalPos;
        [SerializeField] private float _speed = 5f;
        [SerializeField] private GateState _startState = GateState.Open;

        private bool _isLocked;
        private Coroutine _moveRoutine;

        public bool IsLocked => _isLocked;

        private void Start()
        {
            // Safety Check
            if (_movingPart == null)
            {
                Debug.LogError($"[ArenaGate] '{name}' is missing the '_movingPart' reference! Assign the visual child.", gameObject);
                return;
            }

            // Snap to initial state
            if (_startState == GateState.Open)
            {
                _movingPart.localPosition = _openLocalPos;
                _isLocked = false;
            }
            else
            {
                _movingPart.localPosition = _closedLocalPos;
                _isLocked = true;
            }
        }

        public void Lock() => Close();
        public void Unlock() => Open();

        [ContextMenu("Open Gate")]
        public void Open()
        {
            if (!_isLocked || _movingPart == null) return;
            _isLocked = false;

            if (_moveRoutine != null) StopCoroutine(_moveRoutine);
            _moveRoutine = StartCoroutine(MoveToTarget(_openLocalPos));
        }

        [ContextMenu("Close Gate")]
        public void Close()
        {
            if (_isLocked || _movingPart == null) return;
            _isLocked = true;

            if (_moveRoutine != null) StopCoroutine(_moveRoutine);
            _moveRoutine = StartCoroutine(MoveToTarget(_closedLocalPos));
        }

        private IEnumerator MoveToTarget(Vector3 targetLocalPos)
        {
            while (Vector3.Distance(_movingPart.localPosition, targetLocalPos) > 0.01f)
            {
                _movingPart.localPosition = Vector3.MoveTowards(
                    _movingPart.localPosition,
                    targetLocalPos,
                    _speed * Time.deltaTime
                );
                yield return null;
            }
            _movingPart.localPosition = targetLocalPos;
        }

        // --- Editor Helpers ---

        [ContextMenu("Capture Open Position")]
        private void CaptureOpen()
        {
            if (_movingPart) _openLocalPos = _movingPart.localPosition;
            else Debug.LogWarning("Assign _movingPart first!");
        }

        [ContextMenu("Capture Closed Position")]
        private void CaptureClosed()
        {
            if (_movingPart) _closedLocalPos = _movingPart.localPosition;
            else Debug.LogWarning("Assign _movingPart first!");
        }
    }
}