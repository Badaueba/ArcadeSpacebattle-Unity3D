using System;
namespace FATEC.ArcadeSpaceBattle.Models {
	
	public class Point {
		public int playerPoints { set; get; }

		public Point () {}
		public Point (int value) {
			playerPoints = value;
		}
	}
}

