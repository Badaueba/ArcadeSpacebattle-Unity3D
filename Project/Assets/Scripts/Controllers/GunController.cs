using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Abstractions;
using FATEC.ArcadeSpaceBattle.Managers;

namespace FATEC.ArcadeSpaceBattle.Controllers {
    /// <summary>
    /// Controls the shoot of guns
    /// <see cref="FATEC.ArcadeSpaceBattle.Abstractions.IGun"/> object. 
    /// </summary>
    public class GunController {
        /// <summary>List of Guns that going to shoot.</summary>
        protected IGun[] guns { get; set; }
        /// <summary>The joystick to get input</summary>
        protected IJoystick joystick { get; set; }
        /// <summary>The manager to set fired objects</summary>
        protected ManagerInstantiate managerInstantiate { get; set; }
        /// <summary>Time to next shoot.</summary>
        protected float fireRate { get; set; }

        protected GameRoot gameRoot;

        public GunController(
            IGun[] guns,
            IJoystick joystick,
            float fireRate,
            ManagerInstantiate managerInstantiate) {
            this.fireRate = fireRate;
            this.guns = guns;
            this.joystick = joystick;
            this.managerInstantiate = managerInstantiate;
        }

        public IEnumerator Update() {
            while (true) {
                if (joystick.GetButton(0)) {
                    foreach (IGun obj in this.guns) {
                        var instance = obj.Shoot();
                        managerInstantiate.AddInstance(instance);
                    }
                    yield return new WaitForSeconds(this.fireRate);
                }
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
