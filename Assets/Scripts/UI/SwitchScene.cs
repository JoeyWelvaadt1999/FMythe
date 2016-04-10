using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {
	public void Switch(int scene) {
		Application.LoadLevel (scene);
	}
}
