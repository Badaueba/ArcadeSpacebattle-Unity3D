using FATEC.ArcadeSpaceBattle.Behaviours;
using UnityEngine;

namespace FATEC.ArcadeSpaceBattle.Objects {
    /// <summary>
    /// Represent a object Tower
    /// </summary>
    public class Tower {
        /// <summary>Reference to the GameObject in scene</summary>
        public GameObject gameObject;
        /// <summary>Reference to the transfrom of GameObject in scene</summary>
        public Transform transform;
        /// <summary>Guns for shoot</summary>
        public ProjectileGun guns;
        /// <summary>identifier tag</summary>
        public string tag;

        public Tower(GameObject gameObject, Transform transform, ProjectileGun guns, string tag) {
            this.gameObject = gameObject;
            this.transform = transform;
            this.guns = guns;
            this.tag = tag;
        }
    }
}
