using UnityEngine;

public class SpawnPointGizmo : MonoBehaviour
{
    [Header("Visual Settings")]
    public Color color = Color.cyan;
    public float size = 0.5f;

    // Drawn ALWAYS (even when not selected)
    void OnDrawGizmos()
    {
        Gizmos.color = color;

        // 1. Draw the Base position
        Gizmos.DrawWireSphere(transform.position, size);

        // 2. Draw the "Forward" direction (So you know where enemies face)
        Vector3 direction = transform.forward * (size * 3);
        Gizmos.DrawRay(transform.position, direction);

        // 3. Draw a "Arrow Head" to confirm direction
        Vector3 right = (transform.forward + transform.right).normalized * size;
        Vector3 left = (transform.forward - transform.right).normalized * size;
        Gizmos.DrawLine(transform.position + direction, transform.position + direction - right);
        Gizmos.DrawLine(transform.position + direction, transform.position + direction - left);
    }

    // Drawn ONLY when selected (Highlight)
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, size);
    }
}