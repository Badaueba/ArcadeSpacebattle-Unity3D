using System;
using UnityEngine;

namespace FATEC.ArcadeSpaceBattle.Components {
	public class Winner : MonoBehaviour {
		public string winnerPlayer;

		void Awake () {
			DontDestroyOnLoad (this.gameObject);
		}
	}
}

