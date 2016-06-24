using UnityEngine;
using tv.ouya.console.api;
using FATEC.ArcadeSpaceBattle.Abstractions;
namespace FATEC.ArcadeSpaceBattle.DataProviders {
    /// <summary>
    /// Provide information of joyticks input
    /// </summary>
    public class OUYAInputProvider : IInputProvider {

		protected int joystick;
		public OUYAInputProvider (int joystick) {
			this.joystick = joystick;
		}
        public float GetAxis(int index) {
            float axis = 0;
            if (index == 0) {
                #if UNITY_ANDROID && !UNITY_EDITOR
                if (OuyaSDK.OuyaInput.IsControllerConnected(joystick)) {
			        axis = OuyaSDK.OuyaInput.GetAxis(joystick, OuyaController.AXIS_LS_X);
				}	
                #endif
            }
            if (Mathf.Abs(axis) >= 0.2f) {
                return axis;
            }
            else {
                return 0;
            }
        }

        public bool GetButton(int index) {
            bool button = false;
            if (index == 0) {
                #if UNITY_ANDROID && !UNITY_EDITOR
                    if (OuyaSDK.OuyaInput.GetButton(joystick, OuyaController.BUTTON_O)) {
			        	button = true;
			        } 
                #endif
                return button;
            }
            else if (index == 1) {
                #if UNITY_ANDROID && !UNITY_EDITOR
                    if (OuyaSDK.OuyaInput.GetButton(joystick, OuyaController.BUTTON_U)) {
						button = true;
			        }
                #endif
                return button;
            }
            else if (index == 2) {
                #if UNITY_ANDROID && !UNITY_EDITOR
                    if (OuyaSDK.OuyaInput.GetButton(joystick, OuyaController.BUTTON_Y)) {
			        	button = true;
			        }
                #endif
                return button;
            }
            else if (index == 3) {
                #if UNITY_ANDROID && !UNITY_EDITOR
                    if (OuyaSDK.OuyaInput.GetButton(joystick, OuyaController.BUTTON_A)) {
				    	button = true;
			        }
                #endif
                return button;
            }
            if (index == 6) {
                return Input.GetKey(KeyCode.Mouse0);
            }
            else {
                return false;
            }
        }
    }
}