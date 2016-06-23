using System;
using System.Collections;
using UnityEngine;

namespace FATEC.ArcadeSpaceBattle.Components {
	public class TowerShoot : MonoBehaviour {
		public float fireRate;
		public GameObject laser;	

		void Start() {
			StartCoroutine (Updater ());
		}

		private IEnumerator Updater () {
			while (true) {
				GameObject.Instantiate (laser, this.transform.position, this.transform.rotation);		
				yield return new WaitForSeconds (fireRate);
			}
		}
	}
}

