using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Components;
using FATEC.ArcadeSpaceBattle.Models;

namespace FATEC.ArcadeSpaceBattle {
    public class DataCenter : MonoBehaviour {
		
		public Transform ship1;
		public Transform ship2;
		public float fireRate;
		public GameObject laser1;
		public GameObject laser2;
		public GameObject tower1;
		public GameObject tower2;
		public GameObject barrier1;
		public GameObject barrier2;
		public int towerPrice;
		public int barrierPrice;
		public float speed;
        ///--------------------------------------------------------------------------------------------------
        ///Criadas por Lael
        public ColliderChecker colliderCheckerPlayer1;
        public ColliderChecker colliderCheckerPlayer2;
        public Life lifePlayer1;
        public Life lifePlayer2;
        public Point pointPlayer1;
        public Point pointPlayer2;
        ///--------------------------------------------------------------------------------------------------
		public GUIContainer guiContainerPlayer1;
		public GUIContainer guiContainerPlayer2;
    }
}
