using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Abstractions;
using FATEC.ArcadeSpaceBattle.DataProviders;
using FATEC.ArcadeSpaceBattle.Controllers;
using FATEC.ArcadeSpaceBattle.DataProcessors;

namespace FATEC.ArcadeSpaceBattle {
    public class GameRoot : MonoBehaviour {
        protected DataCenter dataCenter;
        protected IInputProvider inputProvider;
        protected RestartController restartController;
		protected Mover moverPlayer1;
		protected MovementController movementeControllerPlayer1;
		protected ShootController shootControllerPlayer1;
		protected DefenseController defenseControllerPlayer1;
		
        void Awake() {
            this.dataCenter = GameObject.Find("DataCenter").GetComponent<DataCenter>();
            this.inputProvider = new KeyboardInputProvider();
			this.moverPlayer1 = new Mover (this.dataCenter.ship1, this.dataCenter.speed);
        }

        void Start() {
            this.restartController = new RestartController(this, this.dataCenter, this.inputProvider);
			movementeControllerPlayer1 = new MovementController (this.inputProvider, this.moverPlayer1, this);
			shootControllerPlayer1 = new ShootController (inputProvider, dataCenter.fireRate, dataCenter.laser1,
			                                              dataCenter.ship1, this);
			defenseControllerPlayer1 = new DefenseController (inputProvider, dataCenter, dataCenter.ship1, 0, this);

        }
    }
}