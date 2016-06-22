using UnityEngine;
using System.Collections;
using System.Collections;


public class LaserMover : MonoBehaviour {

	public Transform transform;
	public float speed;
	void Start (){
		StartCoroutine (Updater ());
	}
	
	private IEnumerator Updater () {
		while (true) {
			transform.Translate ( transform.up * speed * Time.deltaTime);
			yield return new WaitForEndOfFrame ();
		}
	}
}

