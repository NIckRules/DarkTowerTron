using UnityEngine;
using DG.Tweening; // Assuming DOTween is available based on file list

namespace DarkTowerTron.Player
{
    public class AfterImage : MonoBehaviour
    {
        public float duration = 1f;
        
        public void Initialize(Vector3 pos, Quaternion rot)
        {
            transform.position = pos;
            transform.rotation = rot;
            
            // Visuals: Shrink and fade
            // Using DOTween if available, otherwise manual coroutine
            // Based on file list, DOTween is present.
            
            transform.DOScale(Vector3.zero, duration).SetEase(Ease.InQuad);
            
            Renderer rend = GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.DOFade(0f, duration);
            }

            Destroy(gameObject, duration);
        }
    }
}
