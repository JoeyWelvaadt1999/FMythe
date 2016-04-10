using UnityEngine;
using System.Collections;

public class PropSpawner : MonoBehaviour
{
	private Vector2 _bounds;
	[SerializeField]private PropPercentage[] _props;
	[SerializeField]private int _height;
	[SerializeField]private int _width;
	[SerializeField]private int _pixelWidth;
	[SerializeField]private int _pixelHeight;

	void Start() {
		_bounds = new Vector2 ((float)(_pixelWidth * _width), (float)(_pixelHeight * _height));
		for (int x = (int)-_bounds.x/2; x < _bounds.x/2; x++) {
			for (int y = (int)-_bounds.y/2; y < _bounds.y/2; y++) {
				for (int i = 0; i < _props.Length; i++) {
					int temp = Random.Range (0, 100);
					int tempPercentage = _props [i].Percentage;
					if (temp < tempPercentage) {
						Instantiate (_props [i].Prop, new Vector2 ((float)x, (float)y), Quaternion.identity);
					}					
				}
			}
		}
	}
}
