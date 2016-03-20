using UnityEngine;
using FATEC.ArcadeSpaceBattle.Abstractions;

namespace FATEC.ArcadeSpaceBattle.Joysticks {
    /// <summary>
    /// Keyboard joystick.
    /// </summary>
    public class JoystickPlayer2 : IJoystick {
        public float GetAxis(int index) {
            switch (index) {
                case 0: //X
                    var axisX = 0;
                    if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)) {
                        axisX = -1;
                    }
                    if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow)) {
                        axisX = 1;
                    }
                    return axisX;
                case 1: //Y
                    var axisY = 0;
                    if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow)) {
                        axisY = 1;
                    }
                    if (Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow)) {
                        axisY = -1;
                    }
                    return axisY;
                default:
                    return 0;
            }
        }

        public bool GetButton(int index) {
            if (index == 0) {
                return Input.GetKey(KeyCode.RightShift);
            }
            else {
                return false;
            }
        }
    }
}