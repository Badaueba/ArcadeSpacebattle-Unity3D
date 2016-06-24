using UnityEngine;
using System.Collections;

namespace FATEC.ArcadeSpaceBattle.Components {
	
	public class LaserMover : MonoBehaviour {

		public Transform transform;
		public float speed;
		public float lifeTime;
		private IEnumerator updater;
		private IEnumerator lifeTimer;
		void Start (){
			updater = Updater ();
			lifeTimer = LifeTimer();
			StartCoroutine (updater);
			StartCoroutine (lifeTimer);
		}
		
		private IEnumerator Updater () {
			while (true) {
				transform.Translate ( transform.up * speed * Time.deltaTime);
				yield return new WaitForEndOfFrame ();
			}
		}

		private IEnumerator LifeTimer () {
			yield return new WaitForSeconds (lifeTime);
			StopCoroutine (updater);
			StopCoroutine (lifeTimer);
			GameObject.Destroy (transform.gameObject);
		}
	}

}