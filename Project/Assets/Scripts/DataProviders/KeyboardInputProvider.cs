using UnityEngine;
using FATEC.ArcadeSpaceBattle.Abstractions;

namespace FATEC.ArcadeSpaceBattle.DataProviders {
    /// <summary>
    /// Provide information of joyticks input
    /// </summary>
    public class KeyboardInputProvider : IInputProvider {
		
		protected KeyCode left;
		protected KeyCode right;
		protected KeyCode shoot;
		protected KeyCode makeTower;
		protected KeyCode makeBarrier;

		public KeyboardInputProvider (KeyCode left, KeyCode right, KeyCode shoot, KeyCode makeTower, KeyCode makeBarrier) {
			this.left = left;
			this.right = right;
			this.shoot = shoot;
			this.makeTower = makeTower;
			this.makeBarrier = makeBarrier;
		}

        public float GetAxis(int index) {
            switch (index) {
                case 0:
					if (Input.GetKey(right)) {
                        return 1f;

                	}
					else if (Input.GetKey(left)) {
                        return -1f;
                    }
                    else {
                        return 0f;
                    }
                default: return 0f;
            }
        }

        public bool GetButton(int index) {
			if (index == 0) {
				return Input.GetKey (shoot);
			}
			else if (index == 1) {
				return Input.GetKey (makeTower);
			}
			else if (index == 2) {
				return Input.GetKey (makeBarrier);
			}
            else {
                return false;
            }
        }
    }
}