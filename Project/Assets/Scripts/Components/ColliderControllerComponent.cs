using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Models;

namespace FATEC.ArcadeSpaceBattle.Components {
    public class ColliderControllerComponent : MonoBehaviour{

        public GameObject GameObjetcRoot;
        public ColliderChecker colliderChecker;
        public Life life;
        //public Point point;


        void Update() {
            if (this.colliderChecker.GetChecherInfo()) {
                GameObject.Destroy(this.colliderChecker.GetChecherData());
                this.colliderChecker.ResetChecher();
                //point.playerPoints += 25;
                if (this.life.GetHealth() > 0) {
                    this.life.IncreaseHealth(-1);
                }
                else {
                    GameObject.Destroy(this.GameObjetcRoot);
                }
            }
        }
    }
}
