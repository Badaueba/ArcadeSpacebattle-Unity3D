using UnityEngine;
using System.Collections;


namespace FATEC.ArcadeSpaceBattle {
    public class Baudary : MonoBehaviour {
        public float xMin, xMax, yMin, yMax;
        
        public void GetBoundaryCamera(Camera camera) {
            this.yMax = camera.orthographicSize * camera.rect.height;
            this.yMin = -this.yMax;
            this.xMax = ((camera.orthographicSize * Screen.width) / Screen.height) * camera.rect.width;
            this.xMin = -this.xMax;
        }
    }
}