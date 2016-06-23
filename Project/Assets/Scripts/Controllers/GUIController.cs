using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using FATEC.ArcadeSpaceBattle.Models;
namespace FATEC.ArcadeSpaceBattle.Controllers {
	public class GUIController {
		
		protected Text pointsText;
		protected Text healthText;
		protected Point point;
		protected Life life;
		protected MonoBehaviour script;

		public GUIController (Text pointsText, Text HealthText, Point point, Life life, MonoBehaviour script) {
			this.pointsText = pointsText; 
			this.healthText = HealthText;
			this.point = point;
			this.life = life;
			this.script = script;
			this.script.StartCoroutine (Updater ());
		}

		private IEnumerator Updater () {
			while (true) {
				this.pointsText.text = "Points: " + point.points;
				this.healthText.text = "Health: " + life.health;
				yield return new WaitForEndOfFrame ();
			}
		}
			
	}
}

