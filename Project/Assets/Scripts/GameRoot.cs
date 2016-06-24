using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Abstractions;
using FATEC.ArcadeSpaceBattle.DataProviders;
using FATEC.ArcadeSpaceBattle.Controllers;
using FATEC.ArcadeSpaceBattle.DataProcessors;
using FATEC.ArcadeSpaceBattle.Models;

namespace FATEC.ArcadeSpaceBattle {
    public class GameRoot : MonoBehaviour {
        protected DataCenter dataCenter;
        protected IInputProvider inputProviderPlayer1;
		protected IInputProvider inputProviderPlayer2;
        protected RestartController restartController;
		protected Mover moverPlayer1;
		protected Mover moverPlayer2;
		protected MovementController movementeControllerPlayer1;
		protected MovementController movementeControllerPlayer2;
		protected ShootController shootControllerPlayer1;
		protected ShootController shootControllerPlayer2;
		protected DefenseController defenseControllerPlayer1;
		protected DefenseController defenseControllerPlayer2;
		protected Point pointsPlayer1;

        ///--------------------------------------------------------------------------------------------------
        ///Criadas por Lael
        protected ColliderController colliderControllerPlayer1;
        protected ColliderController colliderControllerPlayer2;
        protected Point pointsPlayer2;
        protected GameOverController gameOverController;
        ///--------------------------------------------------------------------------------------------------

		protected GUIController guiControllerPlayer1;
		protected GUIController guiControllerPlayer2;

        void Awake() {
            this.dataCenter = GameObject.Find("DataCenter").GetComponent<DataCenter>();
			//Keyboard/Editor Input
			this.inputProviderPlayer1 = new KeyboardInputProvider (KeyCode.A, KeyCode.D, KeyCode.Space, KeyCode.V, KeyCode.B);
			this.inputProviderPlayer2 = new KeyboardInputProvider (KeyCode.RightArrow, KeyCode.LeftArrow, KeyCode.I, KeyCode.O, KeyCode.P);
			//OUYA Input
			//this.inputProviderPlayer1 = new OUYAInputProvider (0);
			//this.inputProviderPlayer2 = new OUYAInputProvider (1);

			this.moverPlayer1 = new Mover (this.dataCenter.ship1, this.dataCenter.speed);
			this.moverPlayer2 = new Mover (this.dataCenter.ship2, this.dataCenter.speed);
			this.pointsPlayer1 = dataCenter.pointPlayer1;
            ///--------------------------------------------------------------------------------------------------
            ///Criadas por Lael
			this.pointsPlayer2 = dataCenter.pointPlayer2;
            ///--------------------------------------------------------------------------------------------------
        }

        void Start() {
			this.restartController = new RestartController(this, this.dataCenter, this.inputProviderPlayer1);

			movementeControllerPlayer1 = new MovementController (this.inputProviderPlayer1, this.moverPlayer1, this);
			movementeControllerPlayer2 = new MovementController (this.inputProviderPlayer2, this.moverPlayer2, this);

			shootControllerPlayer1 = new ShootController (inputProviderPlayer1, dataCenter.fireRate, dataCenter.laser1,
			                                              dataCenter.ship1, this);
			
			shootControllerPlayer2 = new ShootController (inputProviderPlayer2, dataCenter.fireRate, dataCenter.laser2,
				dataCenter.ship2, this);
			
			defenseControllerPlayer1 = new DefenseController (inputProviderPlayer1, dataCenter.ship1, dataCenter.tower1,
				dataCenter.barrier1, dataCenter.towerPrice, dataCenter.barrierPrice, dataCenter.pointPlayer1, this);
			
			defenseControllerPlayer2 = new DefenseController (inputProviderPlayer2, dataCenter.ship2, dataCenter.tower2,
				dataCenter.barrier2, dataCenter.towerPrice, dataCenter.barrierPrice, dataCenter.pointPlayer2, this);
            ///--------------------------------------------------------------------------------------------------
            ///Criadas por Lael
            this.colliderControllerPlayer1 = new ColliderController(this.dataCenter.colliderCheckerPlayer1, this.dataCenter.lifePlayer1, this.pointsPlayer2 ,this);
            this.colliderControllerPlayer2 = new ColliderController(this.dataCenter.colliderCheckerPlayer2, this.dataCenter.lifePlayer2, this.pointsPlayer1, this);
            this.gameOverController = new GameOverController(this.dataCenter.lifePlayer1, this.dataCenter.lifePlayer2, this);
            ///--------------------------------------------------------------------------------------------------

			this.guiControllerPlayer1 = new GUIController (dataCenter.guiContainerPlayer1.points, dataCenter.guiContainerPlayer1.healh,
				dataCenter.pointPlayer1, dataCenter.lifePlayer1, this);

			this.guiControllerPlayer2 = new GUIController (dataCenter.guiContainerPlayer2.points, dataCenter.guiContainerPlayer2.healh,
				dataCenter.pointPlayer2, dataCenter.lifePlayer2, this);
        }
			
    }
}