using UnityEngine;

namespace DarkTowerTron.Player.Combat
{
    public class PlayerWeaponController : MonoBehaviour
    {
        [Header("Inventory")]
        // We link these in Inspector or Awake
        [SerializeField] private WeaponBase _primaryWeapon;   // Beam
        [SerializeField] private WeaponBase _secondaryWeapon; // Gun

        private void Awake()
        {
            // Auto-link if empty (Backwards compatibility with current prefab setup)
            if (_primaryWeapon == null) _primaryWeapon = GetComponent<PlayerBeam>();
            if (_secondaryWeapon == null) _secondaryWeapon = GetComponent<PlayerGun>();
        }

        public void SetPrimaryFire(bool isFiring)
        {
            if (_primaryWeapon) _primaryWeapon.SetFiring(isFiring);
        }

        public void SetSecondaryFire(bool isFiring)
        {
            if (_secondaryWeapon) _secondaryWeapon.SetFiring(isFiring);
        }

        public void StopAll()
        {
            SetPrimaryFire(false);
            SetSecondaryFire(false);
        }
    }
}