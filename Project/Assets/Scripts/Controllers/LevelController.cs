using UnityEngine;
using System.Collections;
namespace FATEC.ArcadeSpaceBattle.Controllers {
	public class LevelController : MonoBehaviour {

		public int scene;

		public void LoadScene () {
			Application.LoadLevel (scene);
		}
	}

}
