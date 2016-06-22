using UnityEngine;
namespace FATEC.ArcadeSpaceBattle.DataProcessor {

    public class DataChangedChecker{
        private int oldValue;

        public DataChangedChecker() {
            this.oldValue = Random.Range(-1000000, 1000000);
        }

        public bool DataCheck(int currentvalue){
            if(currentvalue == this.oldValue) {
                return false;
            }
            else {
                this.oldValue = currentvalue;
                return true;
            }
        }
	}
}
