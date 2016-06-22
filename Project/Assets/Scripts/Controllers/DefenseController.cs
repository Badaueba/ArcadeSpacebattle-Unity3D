using UnityEngine;
using System;
using System.Collections;

using FATEC.ArcadeSpaceBattle.Abstractions;
using FATEC.ArcadeSpaceBattle.Models;

namespace FATEC.ArcadeSpaceBattle.Controllers {
	public class DefenseController {
		
		protected IInputProvider input;
		protected Transform ship;
		protected GameObject tower;
		protected GameObject barrier;
		protected int towerPrice;
		protected int barrierPrice;
		protected Point points;
		protected MonoBehaviour script;

		public DefenseController ( 
			
			IInputProvider input,
			Transform ship,
			GameObject tower,
			GameObject barrier,
			int towerPrice,
			int barrierPrice,
			Point points,
			MonoBehaviour script){

			this.input = input;
			this.ship = ship;
			this.tower = tower;
			this.barrier = barrier;
			this.towerPrice = towerPrice;
			this.barrierPrice = barrierPrice;
			this.points = points;
			this.script = script;
			script.StartCoroutine (Updater ());
		}
		private IEnumerator Updater () {
			while (true) {
				if ( input.GetButton(1)) {
					//Se caso o dinheiro do player for maior ou igual ao preço da torre, 
					//Entao ele poderá instacia-la.
					if (points.playerPoints >= towerPrice ) {
						GameObject.Instantiate (tower, ship.position, ship.transform.rotation);
						//Depois de instanciar a torre, é descontado dos seus pontos o valor que ela custa.
						points.playerPoints -= towerPrice;
						yield return new WaitForSeconds (0.2f);
					}
				}
				if ( input.GetButton(2)) {
					//Se caso o dinheiro do player for maior ou igual ao preço da barreira, 
					//Entao ele poderá instacia-la.
					if (points.playerPoints >= barrierPrice ) {
						GameObject.Instantiate (barrier, ship.position, ship.transform.rotation);
						//Depois de instanciar a torre, é descontado dos seus pontos o valor que ela custa.
						points.playerPoints -= barrierPrice;
						yield return new WaitForSeconds (0.2f);
					}
				}
				Debug.Log ("points : " + points.playerPoints);
				yield return new WaitForEndOfFrame();
			}
		}
	}
}

