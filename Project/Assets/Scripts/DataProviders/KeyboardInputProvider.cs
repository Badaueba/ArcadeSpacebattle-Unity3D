using UnityEngine;
using FATEC.ArcadeSpaceBattle.Abstractions;

namespace FATEC.ArcadeSpaceBattle.DataProviders {
    /// <summary>
    /// Provide information of joyticks input
    /// </summary>
    public class KeyboardInputProvider : IInputProvider {

        public float GetAxis(int index) {
            switch (index) {
                case 0:
                    if (Input.GetKey(KeyCode.D)) {
                        return 1f;
                    }
                    else if (Input.GetKey(KeyCode.A)) {
                        return -1f;
                    }
                    else {
                        return 0f;
                    }
                case 1:
                    if (Input.GetKey(KeyCode.W)) {
                        return -1f;
                    }
                    else if (Input.GetKey(KeyCode.S)) {
                        return 1f;
                    }
                    else {
                        return 0f;
                    }
                default: return 0f;
            }
        }

        public bool GetButton(int index) {
            if (index == 0) {
                return Input.GetKey(KeyCode.Space);
            }
            else {
                return false;
            }
        }
    }
}