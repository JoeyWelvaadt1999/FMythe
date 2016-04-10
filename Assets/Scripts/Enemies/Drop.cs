using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour {
	[SerializeField]private GameObject _dropable;
	[SerializeField]private int _min;
	[SerializeField]private int _max;

	void Start () {
		if (transform.tag == LayerTags.environment) {
			DropItem ();
		} 
	}

	private bool RandomBool() {
		int temp = Random.Range (_min,_max);
		if (temp == 0) {
			return false;
		} else if (temp == 1) {
			return true;
		}

		return false;
	}

	public void DropItem() {
		if(RandomBool()) {
//			for (int i = 0; i < _dropable.Length; i++) {
				Instantiate (_dropable, transform.position, Quaternion.identity);
//			}				
		}
	}
}
