using UnityEngine;
using System.Collections;

public class HideUI : MonoBehaviour {
	[SerializeField]private GameObject _crafting;
	void Start() {
		_crafting.SetActive(false);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			_crafting.SetActive (!_crafting.activeSelf);
		}
	}
}
