using UnityEngine;
using FATEC.ArcadeSpaceBattle.Abstractions;

namespace FATEC.ArcadeSpaceBattle.Joysticks {
    /// <summary>
    /// Keyboard joystick.
    /// </summary>
    public class JoystickPlayer1 : IJoystick {
        public float GetAxis(int index) {
            switch (index) {
                case 0: //X
                    var axisX = 0;
                    if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) {
                        axisX = -1;
                    }
                    if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A)) {
                        axisX = 1;
                    }
                    return axisX;
                case 1: //Y
                    var axisY = 0;
                    if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)) {
                        axisY = 1;
                    }
                    if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W)) {
                        axisY = -1;
                    }
                    return axisY;
                default:
                    return 0;
            }
        }

        public bool GetButton(int index) {
            if (index == 0) {
                return Input.GetKey(KeyCode.LeftShift);
            }
            else {
                return false;
            }
        }
    }
}