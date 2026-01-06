using UnityEngine;

namespace DarkTowerTron.Core.Utils
{
    public class Rotator : MonoBehaviour
    {
        public enum RotateDirection
        {
            Clockwise = 1,
            CounterClockwise = -1
        }

        [Header("Settings")]
        public Vector3 axis = Vector3.up;
        public float speed = 100f;

        [Tooltip("Direction of rotation relative to the axis.")]
        public RotateDirection direction = RotateDirection.Clockwise;

        public bool localSpace = true;

        private void Update()
        {
            if (speed == 0) return;

            // Math: Speed * Direction (1 or -1) * DeltaTime
            float finalStep = speed * (int)direction * Time.deltaTime;

            if (localSpace)
                transform.Rotate(axis, finalStep, Space.Self);
            else
                transform.Rotate(axis, finalStep, Space.World);
        }

        // API for AI/Events to change direction at runtime
        public void SetDirection(RotateDirection newDir) => direction = newDir;

        public void ToggleDirection()
        {
            direction = direction == RotateDirection.Clockwise ?
                        RotateDirection.CounterClockwise :
                        RotateDirection.Clockwise;
        }
    }
}