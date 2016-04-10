using UnityEngine;
using System.Collections;

public class SetSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float height = Camera.main.orthographicSize * 2;
		float width = height * Screen.width / Screen.height;
		Vector3 _screenSize = new Vector3 (width / 10, height / 10, 1);

		transform.localScale = _screenSize;

	}
}
