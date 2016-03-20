using FATEC.ArcadeSpaceBattle.Behaviours;
using UnityEngine;

namespace FATEC.ArcadeSpaceBattle.Objects {
    /// <summary>
    /// Represent a object Ship
    /// </summary>
    public class Ship {
        /// <summary>Reference to the GameObject in scene</summary>
        public GameObject gameObject;
        /// <summary>Reference to the transfrom of GameObject in scene</summary>
        public Transform transform;
        /// <summary>Behaviour to move</summary>
        public TransformMoviment mover;
        /// <summary>Guns for shoot</summary>
        public ProjectileGun[] guns;
        /// <summary>identifier tag</summary>
        public string tag;

        public Ship(GameObject gameObject, Transform transform, TransformMoviment mover, ProjectileGun[] guns, string tag) {
            this.gameObject = gameObject;
            this.transform = transform;
            this.mover = mover;
            this.guns = guns;
            this.tag = tag;
        }
    }
}
