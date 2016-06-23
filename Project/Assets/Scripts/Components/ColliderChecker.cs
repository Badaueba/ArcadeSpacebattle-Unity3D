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
        protected GameObject ChecherData;

        public void ResetChecher() {
            this.ChecherInfo = false;
            this.ChecherData = null;
        }
        public bool GetChecherInfo() {
            return this.ChecherInfo;
        }
        public GameObject GetChecherData() {
            return this.ChecherData;
        }

        protected void Awake() {
            this.ChecherInfo = false;
            this.ChecherData = null;
        }

        protected void OnTriggerEnter2D(Collider2D other) {
            if (other.CompareTag(this.tagToChecker)) {
                this.ChecherInfo = true;
                this.ChecherData = other.gameObject;
            }
        }
    }
}
