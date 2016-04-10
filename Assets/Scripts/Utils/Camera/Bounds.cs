using UnityEngine;
using System.Collections;

public class Bounds : MonoBehaviour {
	[SerializeField]private Vector2 _bounds;
	[SerializeField]private GameObject _object;
	[SerializeField]private float _zIndex;
	[SerializeField]private bool _camera;
	private Vector2 _screenSize = new Vector2();
	private Vector2 _curPosition;


	void Update () {
		GetCameraSize ();
		CheckIfAtBoundrey ();
	}

	void CheckIfAtBoundrey() {
		if (_object.transform.position.x - _screenSize.x / 2 > -_bounds.x + 1 &&
			_object.transform.position.x + _screenSize.x / 2 < _bounds.x - 1) {
			_curPosition.x = _object.transform.position.x;
		} else {

			Vector2 tpos = _object.transform.position;
			tpos.x = _curPosition.x;
			_object.transform.position = new Vector3(tpos.x, tpos.y, _zIndex);
		}

		if (_object.transform.position.y - _screenSize.y / 2 > -_bounds.y + 1 &&
			_object.transform.position.y + _screenSize.y / 2 < _bounds.y - 1) {
			_curPosition = _object.transform.position;
		} else {

			Vector2 tpos = _object.transform.position;
			tpos.y = _curPosition.y;
			_object.transform.position = new Vector3(tpos.x, tpos.y, _zIndex);
		}
	}

	void GetCameraSize () {
		if (_camera) {
			float height = Camera.main.orthographicSize * 2;
			float width = height * Screen.width / Screen.height;
			_screenSize = new Vector2 (width, height);
		} else {
			_screenSize = new Vector2 (3, 3);
		}
		
	}
}
