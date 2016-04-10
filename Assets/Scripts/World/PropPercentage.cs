using UnityEngine;
using System.Collections;

[System.Serializable]
public class PropPercentage : System.Object {
	[SerializeField]private GameObject _prop;
	[Range(0,100)][SerializeField]private int _percentage;
	public GameObject Prop {
		get {
			return _prop;
		}
	}

	public int Percentage {
		get { 
			return _percentage;
		} 
	}
}
