using FATEC.ArcadeSpaceBattle.Behaviours;
using UnityEngine;

namespace FATEC.ArcadeSpaceBattle.Objects {
    /// <summary>
    /// Represent a object Projectile
    /// </summary>
    public class Projectile {
        /// <summary>Reference to the GameObject in scene</summary>
        public GameObject gameObject;
        /// <summary>Reference to the transfrom of GameObject in scene</summary>
        public Transform transform;
        /// <summary>Behaviour to move</summary>
        public TransformMoviment mover;
        /// <summary>identifier tag</summary>
        public string tag;

        public Projectile(GameObject gameObject, Transform transform, TransformMoviment mover, string tag) {
            this.gameObject = gameObject;
            this.transform = transform;
            this.mover = mover;
            this.tag = tag;
        }
    }
}