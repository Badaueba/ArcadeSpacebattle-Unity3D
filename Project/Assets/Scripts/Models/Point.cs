using System;
using UnityEngine;
namespace FATEC.ArcadeSpaceBattle.Models {
	
	public class Point : MonoBehaviour {
		public int playerPoints { set; get; }

		public Point () {}
		public Point (int value) {
			playerPoints = value;
		}
	}
}

