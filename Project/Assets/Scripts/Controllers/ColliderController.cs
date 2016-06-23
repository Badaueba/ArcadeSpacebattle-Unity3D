using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Components;
using FATEC.ArcadeSpaceBattle.Models;

namespace FATEC.ArcadeSpaceBattle.Controllers { 
    public class ColliderController : MonoBehaviour{

        protected MonoBehaviour script;
        protected ColliderChecker colliderChecker;
        protected Life life;
        protected Point point;

        public ColliderController(ColliderChecker colliderChecker, Life life, Point point, MonoBehaviour script) {
            this.colliderChecker = colliderChecker;
            this.life = life;
            this.point = point;
            this.script = script;
            script.StartCoroutine(Updater());
        }
        protected IEnumerator Updater() {
            while (true) {
                if (this.colliderChecker.GetChecherInfo()) {
                    this.life.IncreaseHealth(-1);
					point.points += 25;
                    GameObject.Destroy(this.colliderChecker.GetChecherData());
                    this.colliderChecker.ResetChecher();
                }
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
