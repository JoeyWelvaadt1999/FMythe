using UnityEngine;
using System.Collections;

public class LoadMovie : MonoBehaviour {
	[SerializeField]private GameObject _plane;
	private MovieTexture _texture;

	void Start() {
		 _texture = (MovieTexture)_plane.GetComponent<Renderer> ().material.mainTexture;
		_texture.Play ();
	}
	void Update() {
		if (!_texture.isPlaying) {
			Application.LoadLevel (2);
		}
	}
}
