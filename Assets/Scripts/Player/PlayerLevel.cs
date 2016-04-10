using UnityEngine;
using System.Collections;

public class PlayerLevel : MonoBehaviour {
	private PlayerStats _playerStats;
	private float _startExpierence = 30;
	private float _neededExpierence;
	public float Expierence{ get; set;}

	void Start() {
		_playerStats = GetComponent<PlayerStats> ();
	}

	void Update() {
		IncreaseLevel ();
	}

	private void CalculateNeededExpierence () {
		_neededExpierence = _startExpierence * _playerStats.Level;	
	}

	public void IncreaseLevel () {
		CalculateNeededExpierence ();
		if (Expierence >= _neededExpierence) {
			_playerStats.Level += 1;
		}
		Debug.Log(_playerStats.Level);
	}
}
