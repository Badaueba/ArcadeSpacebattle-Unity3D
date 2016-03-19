using FATEC.OOTest.Behaviours;
using FATEC.OOTest.Objects;
using System.Collections;
using UnityEngine;

namespace FATEC.OOTest.Managers {
    /// <summary>
    /// Manager of the all objects instantiate by guns
    /// </summary>
    public class ManagerInstantiate {
        /// <summary>List of the all projectiles in scene</summary>
        private Projectile[] projectiles;
        /// <summary>List of the all barriers in scene</summary>
        private Barrier[] barriers;
        /// <summary>List of the all towers in scene</summary>
        private Tower[] towers;

        public ManagerInstantiate() {
            this.projectiles = new Projectile[0];
            this.barriers = new Barrier[0];
            this.towers = new Tower[0];
        }

        public IEnumerator Update() {
            while (true) {
                if (this.projectiles.Length > 0) {
                    foreach (Projectile p in this.projectiles) {
                        if (p != null) {
                            p.mover.Move(0 , 0.2f);
                        }
                    }
                }
                yield return new WaitForEndOfFrame();
            }
        }

        public void AddInstance(GameObject instance) {
            if (instance.CompareTag("laser")) {
                var p = new Projectile(
                    instance.gameObject,
                    instance.GetComponent<Transform>(),
                    instance.GetComponent<TransformMoviment>(),
                    instance.tag);
                this.projectiles = AddPojectile(this.projectiles, p);
            }
            if (instance.CompareTag("barrier")) {
                var b = new Barrier(
                    instance.gameObject,
                    instance.GetComponent<Transform>(),
                    instance.tag);
                this.barriers = AddBarrier(this.barriers, b);
            }
            if (instance.CompareTag("tower")) {
                var t = new Tower(
                    instance.gameObject,
                    instance.GetComponent<Transform>(),
                    instance.GetComponent<ProjectileGun>(),
                    instance.tag);
                this.towers = AddTower(this.towers, t);
            }
        }
        public Projectile[] AddPojectile(Projectile[] array, Projectile objToAdd) {
            var updateArray = new Projectile[array.Length + 1];
            for (int i = 0; i < array.Length; i++) {
                updateArray[i] = array[i];
            }
            updateArray[updateArray.Length - 1] = objToAdd;
            return updateArray;
        }
        public Barrier[] AddBarrier(Barrier[] array, Barrier objToAdd) {
            var updateArray = new Barrier[array.Length + 1];
            for (int i = 0; i < array.Length; i++) {
                updateArray[i] = array[i];
            }
            updateArray[updateArray.Length - 1] = objToAdd;
            return updateArray;
        }
        public Tower[] AddTower(Tower[] array, Tower objToAdd) {
            var updateArray = new Tower[array.Length + 1];
            for (int i = 0; i < array.Length; i++) {
                updateArray[i] = array[i];
            }
            updateArray[updateArray.Length - 1] = objToAdd;
            return updateArray;
        }
    }
}