using UnityEngine;
using FATEC.ArcadeSpaceBattle.Abstractions;

namespace FATEC.ArcadeSpaceBattle.Behaviours {
    /// <summary>
    /// Moves the current game object by transform.
    /// </summary>
    public class TransformMoviment : MonoBehaviour, IMover {
        [SerializeField]
        /// <summary>Reference to the transform component.</summary
        private new Transform transform;

        public TransformMoviment(Transform transform) {
            this.transform = transform;
        }

        public void Move(float x, float y) {
            this.transform.Translate(x, y, 0);
        }
    }
}