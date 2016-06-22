using System;
using UnityEngine;
namespace FATEC.ArcadeSpaceBattle.DataProcessors {
	public class Mover {
		private new Transform transform;
		private float speed;
		public Mover ( Transform transform, float speed ){
			this.transform = transform;
			this.speed = speed;
		}

		public void Move( float x ) {
			transform.Translate (x * speed * Time.deltaTime, 0, 0);
		}
	}
}

