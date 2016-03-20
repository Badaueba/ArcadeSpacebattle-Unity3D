using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Abstractions;

namespace FATEC.ArcadeSpaceBattle.Controllers {
    /// <summary>
    /// Controls the movement of a ship
    /// <see cref="FATEC.ArcadeSpaceBattle.Abstractions.IMover"/> object. 
    /// </summary>
    public class MovimentController {
        /// <summary>Object that going to move</summary>
        protected IMover mover { get; set; }
        /// <summary>The joystick to get input</summary>
        protected IJoystick joystick { get; set; }
        /// <summary>The amount of movement to be applied (meters).</summary>
        protected float amount { get; set; }

        public MovimentController(
            IMover mover,
            IJoystick joystick,
            float amount) {
            this.amount = amount;
            this.mover = mover;
            this.joystick = joystick;
        }

        public IEnumerator Update() {
            while (true) {
                var axisX = this.joystick.GetAxis(0) * this.amount;
                var axisY = this.joystick.GetAxis(1) * this.amount;
                if (axisX != 0 || axisY != 0) {
                    this.mover.Move(axisX, axisY);
                }
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
