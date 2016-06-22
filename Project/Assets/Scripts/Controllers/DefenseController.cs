using UnityEngine;
using System;
using System.Collections;

using FATEC.ArcadeSpaceBattle.Abstractions;

namespace FATEC.ArcadeSpaceBattle.Controllers {
	public class DefenseController {
		
		protected IInputProvider input;
		/// <summary>
		/// The data center.
		/// Estou usando o datacenter porque
		/// é preciso pegar os pontos atualizados sempre
		/// se passar os pontos do player apenas no construtor
		/// nao estariam atualizados sempre quando for tentar utilizar
		/// </summary>
		protected DataCenter dataCenter;
		protected Transform ship;
		/// <summary>
		/// The index of the player.
		/// Esse index determina que player usara essa controller
		/// 0 = player1 
		/// 1 = player2
		/// </summary>
		protected int playerIndex;
		protected MonoBehaviour script;

		public DefenseController ( IInputProvider input,
			DataCenter dataCenter,
			Transform ship,
			int playerIndex,
			MonoBehaviour script){

			this.input = input;
			this.dataCenter = dataCenter;
			this.ship = ship;
			this.playerIndex = playerIndex;
			this.script = script;
			script.StartCoroutine (Updater ());
		}
		private IEnumerator Updater () {
			while (true) {
				if ( input.GetButton(1)) {
					//Se caso o dinheiro do player for maior ou igual ao preço da torre, 
					//Entao ele poderá instacia-la.
					if (dataCenter.points [playerIndex] >= dataCenter.towerPrice) {
						GameObject.Instantiate (dataCenter.tower, ship.position, ship.transform.rotation);
						//Depois de instanciar a torre, é descontado dos seus pontos o valor que ela custa.
						dataCenter.points[ playerIndex ] -= dataCenter.towerPrice;
						yield return new WaitForSeconds (dataCenter.fireRate);
					}
				}
				if ( input.GetButton(2)) {
					//Se caso o dinheiro do player for maior ou igual ao preço da barreira, 
					//Entao ele poderá instacia-la.
					if (dataCenter.points [playerIndex] >= dataCenter.barrierPrice) {
						GameObject.Instantiate (dataCenter.barrier, ship.position, ship.transform.rotation);
						//Depois de instanciar a barreira, é descontado dos seus pontos o valor que ela custa.
						dataCenter.points[ playerIndex ] -= dataCenter.barrierPrice;
						yield return new WaitForSeconds (dataCenter.fireRate);
					}
				}

				yield return new WaitForEndOfFrame();
			}
		}
	}
}

