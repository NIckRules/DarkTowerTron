using UnityEngine;
using DG.Tweening; // Make sure DOTween is imported

public class SpearWeapon : MonoBehaviour
{
    [Header("References")]
    public Transform spearMesh; // Assign the "SpearMesh" object
    public Transform firePoint; // A point at the tip of the spear (optional, or use calculations)

    [Header("Stats")]
    public float thrustDistance = 2f;
    public float attackDuration = 0.05f; // Super snappy
    public float recoveryDuration = 0.2f;
    public float attackWidth = 0.8f;
    public float attackRange = 3.5f;

    [Header("Damage")]
    public float tipDamageThreshold = 2.0f; // Distance where "Shaft" becomes "Tip"

    private bool isAttacking = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            Attack();
        }
    }

    private Vector3 originalScale;
    private Vector3 originalPos;

    void Start()
    {
        // 1. Remember the shape you set in the editor!
        originalScale = spearMesh.localScale;
        originalPos = spearMesh.localPosition;
    }

    void Attack()
    {
        isAttacking = true;

        // 2. Kill old animations to prevent glitches if you click fast
        spearMesh.DOKill();

        // 3. Reset to the "Normal" shape (Scale 1,1,1 usually)
        spearMesh.localScale = originalScale;
        spearMesh.localPosition = originalPos;

        Sequence stab = DOTween.Sequence();

        // FORWARD THRUST
        // We move on Z (Forward)
        stab.Append(spearMesh.DOLocalMoveZ(thrustDistance, attackDuration).SetEase(Ease.OutQuad));

        // STRETCH
        // We stretch on Z because the container points Forward
        // We multiply the original Z scale by 1.5 to stretch it relative to its size
        stab.Join(spearMesh.DOScaleZ(originalScale.z * 1.5f, attackDuration));

        // CHECK HIT
        stab.AppendCallback(() => CheckHit());

        // PAUSE
        stab.AppendInterval(0.05f);

        // RETRACT
        stab.Append(spearMesh.DOLocalMoveZ(originalPos.z, recoveryDuration).SetEase(Ease.OutQuad));
        stab.Join(spearMesh.DOScaleZ(originalScale.z, recoveryDuration)); // Return to normal Z

        stab.OnComplete(() => isAttacking = false);
    }

    void CheckHit()
    {
        // 2. Logic: The Hitbox
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;
        Vector3 boxCenter = origin + (direction * (attackRange / 2));
        Vector3 boxSize = new Vector3(attackWidth, 1f, attackRange);

        // Debug Draw
        // ExtDebug.DrawBox(boxCenter, boxSize / 2, transform.rotation, Color.red, 0.5f);

        Collider[] hits = Physics.OverlapBox(boxCenter, boxSize / 2, transform.rotation);

        foreach (Collider col in hits)
        {
            if (col.CompareTag("Enemy"))
            {
                float distance = Vector3.Distance(origin, col.transform.position);

                if (distance > tipDamageThreshold)
                {
                    Debug.Log($"<color=red>CRITICAL TIP HIT! Dist: {distance}</color>");
                    // Apply High Damage + Stagger
                }
                else
                {
                    Debug.Log($"<color=grey>Weak Shaft Hit. Dist: {distance}</color>");
                    // Apply Low Damage + Pushback
                }
            }
        }
    }

    // Draw Gizmos to see range in Editor
    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Matrix4x4 rotationMatrix = Matrix4x4.TRS(transform.position + transform.forward * (attackRange / 2), transform.rotation, new Vector3(attackWidth, 1f, attackRange));
        Gizmos.matrix = rotationMatrix;
        Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
    }
}