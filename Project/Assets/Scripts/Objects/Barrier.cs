using UnityEngine;

namespace FATEC.ArcadeSpaceBattle.Objects {
    /// <summary>
    /// Represent a object Barrier
    /// </summary>
    public class Barrier {
        /// <summary>Reference to the GameObject in scene</summary>
        public GameObject gameObject;
        /// <summary>Reference to the transfrom of GameObject in scene</summary>
        public Transform transform;
        /// <summary>identifier tag</summary>
        public string tag;

        public Barrier(GameObject gameObject, Transform transform, string tag) {
            this.gameObject = gameObject;
            this.transform = transform;
            this.tag = tag;
        }
    }
}