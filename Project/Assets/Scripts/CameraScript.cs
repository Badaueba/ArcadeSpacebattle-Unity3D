using UnityEngine;
using System.Collections;

namespace FATEC.ArcadeSpaceBattle {
    public class CameraScript : MonoBehaviour {

        public float intensityShake = 0.1f;
        public float timerShake = 1f;
        private float fatorShake;

        private Vector3 originalPosition;

        
        void OnGUI() {
            if (GUI.Button(new Rect(10f, 100f, 80f, 30f), "Tremer tela")) Shake();
        }
        
        void Update() {
            if (fatorShake > 0) {
                fatorShake -= timerShake * Time.deltaTime;
                if (fatorShake > 0) {
                    transform.position = new Vector3(originalPosition.x + Random.Range(-fatorShake, fatorShake),
                                                 originalPosition.y + Random.Range(-fatorShake, fatorShake),
                                                 transform.position.z);
                }
                else {
                    transform.position = new Vector3(originalPosition.x, originalPosition.y, transform.position.z);
                }
            }
            else {
                fatorShake = 0;
                transform.position = new Vector3(originalPosition.x, originalPosition.y, transform.position.z);
            }
        }
        public void Shake() {
            originalPosition = transform.position;
            fatorShake = intensityShake;
        }
    }
}