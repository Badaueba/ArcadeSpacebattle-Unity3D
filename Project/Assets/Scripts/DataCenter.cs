using UnityEngine;
using System.Collections;
namespace FATEC.ArcadeSpaceBattle {
    public class DataCenter : MonoBehaviour {

		/// <summary>
		/// The points.
		/// points[0]  referentet aos pontos do player1 
		/// points[1]  referente aos pontos do player2
		/// </summary>
		public int[] points =  new int[] { 0, 0 };
		public Transform ship1;
		public Transform ship2;
		public float fireRate;
		public GameObject laser1;
		public GameObject laser2;
		public GameObject tower;
		public GameObject barrier;
		public int towerPrice;
		public int barrierPrice;
		public float speed;
    }
}
