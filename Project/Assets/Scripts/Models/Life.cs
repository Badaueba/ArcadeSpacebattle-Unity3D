using UnityEngine;
using System.Collections;

namespace FATEC.ArcadeSpaceBattle.Models {
    public class Life : MonoBehaviour{
        public int health;

        public int GetHealth() {
            return this.health;
        }
        public void SetHealt(int value) {
            this.health = value;
        }
        public void IncreaseHealth(int value) {
            this.health += value;
        }

        public Life(int health) {
            this.health = health;
        }
    }
}
