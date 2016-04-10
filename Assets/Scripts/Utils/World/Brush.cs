using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Brush : MonoBehaviour {
	[SerializeField]private float _brushRadius = 10;
	public float Radius {
		get { 
			return _brushRadius;
		}
	}

	public Vector2 MousePosition() {
		Vector2 mousePos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		Vector2 newMousePos = Camera.main.ScreenToWorldPoint (mousePos);
		return newMousePos;
	}


	void OnDrawGizmos() {
		Gizmos.DrawWireSphere (MousePosition(), _brushRadius);
	}
}
