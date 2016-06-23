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
        protected IInputProvider inputProvider;
        protected RestartController restartController;
		protected Mover moverPlayer1;
		protected MovementController movementeControllerPlayer1;
		protected ShootController shootControllerPlayer1;
		protected DefenseController defenseControllerPlayer1;
		protected Point pointsPlayer1;

        ///--------------------------------------------------------------------------------------------------
        ///Criadas por Lael
        protected ColliderController colliderControllerPlayer1;
        protected ColliderController colliderControllerPlayer2;
        protected Point pointsPlayer2;
        protected GameOverController gameOverController;
        ///--------------------------------------------------------------------------------------------------

        void Awake() {
            this.dataCenter = GameObject.Find("DataCenter").GetComponent<DataCenter>();
            this.inputProvider = new KeyboardInputProvider();
			this.moverPlayer1 = new Mover (this.dataCenter.ship1, this.dataCenter.speed);
			this.pointsPlayer1 = new Point (500);
            ///--------------------------------------------------------------------------------------------------
            ///Criadas por Lael
            this.pointsPlayer2 = new Point(500);
            ///--------------------------------------------------------------------------------------------------
        }

        void Start() {
            this.restartController = new RestartController(this, this.dataCenter, this.inputProvider);
			movementeControllerPlayer1 = new MovementController (this.inputProvider, this.moverPlayer1, this);
			shootControllerPlayer1 = new ShootController (inputProvider, dataCenter.fireRate, dataCenter.laser1,
			                                              dataCenter.ship1, this);
			defenseControllerPlayer1 = new DefenseController (inputProvider, dataCenter.ship1, dataCenter.tower,
				dataCenter.barrier, dataCenter.towerPrice, dataCenter.barrierPrice, pointsPlayer1, this);
            ///--------------------------------------------------------------------------------------------------
            ///Criadas por Lael
            this.colliderControllerPlayer1 = new ColliderController(this.dataCenter.colliderCheckerPlayer1, this.dataCenter.lifePlayer1, this.pointsPlayer2 ,this);
            this.colliderControllerPlayer2 = new ColliderController(this.dataCenter.colliderCheckerPlayer2, this.dataCenter.lifePlayer2, this.pointsPlayer1, this);
            this.gameOverController = new GameOverController(this.dataCenter.lifePlayer1, this.dataCenter.lifePlayer2, this);
            ///--------------------------------------------------------------------------------------------------
        }
    }
}