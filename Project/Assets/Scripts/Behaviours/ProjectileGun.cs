using UnityEngine;
using FATEC.ArcadeSpaceBattle.Abstractions;
using FATEC.ArcadeSpaceBattle.Objects;

namespace FATEC.ArcadeSpaceBattle.Behaviours {
    /// <summary>
    /// Shoot a projectile or other thing.
    /// </summary>
    public class ProjectileGun : MonoBehaviour, IGun {
        [SerializeField]
        /// <summary>Reference to the gun transform component.</summary>
        private new Transform transform;
        [SerializeField]
        /// <summary>Reference to the ammo that will be used.</summary>
        private GameObject ammo;

        public ProjectileGun(
            Transform transform,
            GameObject ammo) {
            this.transform = transform;
            this.ammo = ammo;
        }

        public GameObject Shoot() {
            GameObject clone = (GameObject) GameObject.Instantiate(this.ammo, this.transform.position, this.transform.rotation);
            return clone;
        }
    }
}