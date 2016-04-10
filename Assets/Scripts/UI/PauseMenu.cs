using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public bool IsPaused { get; set;}
	void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
			IsPaused = !IsPaused;
			Time.timeScale = IsPaused ? 1 : 0;
		}
	} 
}
