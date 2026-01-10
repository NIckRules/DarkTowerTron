using UnityEngine;
using System;
using System.Collections.Generic;

namespace DarkTowerTron.Systems.Stats
{
    [Serializable]
    public class ModifiableStat
    {
        [SerializeField] private float _baseValue;
        private float _additiveMod = 0f;
        private float _multiplicativeMod = 1f;

        // Cache the result to avoid math every frame
        private float _cachedValue;
        private bool _isDirty = true;

        public float BaseValue
        {
            get => _baseValue;
            set { _baseValue = value; _isDirty = true; }
        }

        public ModifiableStat(float baseValue)
        {
            _baseValue = baseValue;
        }

        public float Value
        {
            get
            {
                if (_isDirty)
                {
                    _cachedValue = (_baseValue + _additiveMod) * _multiplicativeMod;
                    _isDirty = false;
                }
                return _cachedValue;
            }
        }

        public void AddModifier(float amount)
        {
            _additiveMod += amount;
            _isDirty = true;
        }

        public void AddMultiplier(float amount)
        {
            // E.g. +0.1 (10%) makes mult 1.1
            _multiplicativeMod += amount;
            _isDirty = true;
        }

        public void Reset()
        {
            _additiveMod = 0f;
            _multiplicativeMod = 1f;
            _isDirty = true;
        }
    }
}