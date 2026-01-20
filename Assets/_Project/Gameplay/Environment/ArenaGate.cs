using UnityEngine;
using System.Collections;

namespace DarkTowerTron.Gameplay.Environment
{
    public class ArenaGate : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private Vector3 _closedPosition;
        [SerializeField] private Vector3 _openPosition;
        [SerializeField] private float _speed = 2f;

        private Vector3 _targetPosition;
        private bool _isClosed = false;

        private void Start()
        {
            // Assume start position is the open position unless otherwise set
            if (_openPosition == Vector3.zero) _openPosition = transform.position;
            
            // Assume we want to close downwards or whatever implies "closed"
            if (_closedPosition == Vector3.zero) _closedPosition = transform.position + Vector3.up * 3f;

            _targetPosition = _openPosition;
        }

        private void Update()
        {
            // Simple slide animation
            transform.position = Vector3.Lerp(transform.position, _targetPosition, Time.deltaTime * _speed);
        }

        // --- PUBLIC API ---

        public void Close()
        {
            if (_isClosed) return;
            _isClosed = true;
            _targetPosition = _closedPosition;
        }

        public void Open()
        {
            if (!_isClosed) return;
            _isClosed = false;
            _targetPosition = _openPosition;
        }

        // Keep legacy method just in case
        public void ForceClose() => Close();
    }
}