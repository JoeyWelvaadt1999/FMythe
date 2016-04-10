using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossSpawning : MonoBehaviour {
	[SerializeField]private Image _bossBar;
	private float _waitTime;
	private float _decreaseBar = 10.0f;

	void Start () {
	
	}

	void Update () {
		_waitTime += Time.deltaTime;
		if(_waitTime >= _decreaseBar) {
			_bossBar.fillAmount -= 0.01f;
			_waitTime = 0;
			if (_bossBar.fillAmount >= 1) {
				//Spawn Boss
			}
		}
	}

	public void IncreaseBar () {
		_bossBar.fillAmount += 0.05f;
	}
}
