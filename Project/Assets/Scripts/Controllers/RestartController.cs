using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Abstractions;
using FATEC.ArcadeSpaceBattle.DataProviders;
using FATEC.ArcadeSpaceBattle.DataProcessors;


namespace FATEC.ArcadeSpaceBattle.Controllers {
    /// <summary>
    /// Restart the match
    /// </summary>
    public class RestartController {

        protected MonoBehaviour script;
        protected DataCenter dataCenter;

        protected IInputProvider inputProvider;

        protected IEnumerator thisCoroutine;

        public void StopCoroutine() {
            this.script.StopCoroutine(this.thisCoroutine);
        }

        public RestartController(MonoBehaviour script, DataCenter dataCenter, IInputProvider inputProvider) {
            this.script = script;
            this.dataCenter = dataCenter;
            this.inputProvider = inputProvider;
            this.thisCoroutine = Updater();
            this.script.StartCoroutine(this.thisCoroutine);
        }

        public IEnumerator Updater() {
            while (true) {
                if (this.inputProvider.GetButton(6)) {
                    Application.LoadLevel(Application.loadedLevel);
                }
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
