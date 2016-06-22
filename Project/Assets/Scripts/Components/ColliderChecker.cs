using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.DataProviders;
using FATEC.ArcadeSpaceBattle.DataProcessors;

namespace FATEC.ArcadeSpaceBattle.Components {
    /// <summary>
    /// Check if the collider received the other collider with tag to check
    /// </summary>
    public class ColliderChecker : MonoBehaviour {

        public string tagToChecker = "Untagged";
        protected bool ChecherInfo;

        public void SetGoalChecherInfo(bool value) {
            this.ChecherInfo = value;
        }
        public bool GetGoalChecherInfo() {
            return this.ChecherInfo;
        }

        protected void Awake() {
            this.ChecherInfo = false;
        }

        protected void OnTriggerEnter(Collider other) {
            if (other.CompareTag(this.tagToChecker)) {
                this.ChecherInfo = true;
            }
        }
    }
}
