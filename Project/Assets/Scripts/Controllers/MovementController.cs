using UnityEngine;
using System.Collections;
using FATEC.ArcadeSpaceBattle.Abstractions;
using FATEC.ArcadeSpaceBattle.DataProcessors;

public class MovementController {

	protected MonoBehaviour script;
	protected IInputProvider input;
	protected Mover mover;

	public MovementController ( IInputProvider input,
	                           Mover mover,
	                           MonoBehaviour script ) {
		this.input = input;
		this.mover = mover;
		this.script = script;
		script.StartCoroutine (Updater ());
	}

	protected IEnumerator Updater() {
		while (true) {

			this.mover.Move( input.GetAxis(0));
			yield return new WaitForEndOfFrame();
		}

	}

}
