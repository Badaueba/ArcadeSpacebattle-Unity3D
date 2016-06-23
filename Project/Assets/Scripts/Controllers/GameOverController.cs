using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Models;

namespace FATEC.ArcadeSpaceBattle.Controllers {
    public class GameOverController : MonoBehaviour {

        protected MonoBehaviour script;
        protected Life lifePlayer1;
        protected Life lifePlayer2;

        public GameOverController(Life lifePlayer1, Life lifePlayer2,  MonoBehaviour script) {
            this.lifePlayer1 = lifePlayer1;
            this.lifePlayer2 = lifePlayer2;
            this.script = script;
            script.StartCoroutine(Updater());
        }
        protected IEnumerator Updater() {
            while (true) {
                if (this.lifePlayer1.GetHealth() <= 0) {
                    Application.LoadLevel(2);
                }
                if(this.lifePlayer2.GetHealth() <= 0) {
                    Application.LoadLevel(3);
                }
                yield return new WaitForEndOfFrame();
            }

        }

    }
}