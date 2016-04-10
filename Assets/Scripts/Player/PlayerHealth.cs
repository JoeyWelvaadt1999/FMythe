using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : LifePoints
{
	[SerializeField]private Image _healthBar;
	[SerializeField]private int _playerHealth;
	void Awake () {
		_health = _playerHealth;
		TakeDamage (0, this.gameObject, GetComponent<Animator> ());
	}

	void Update() {
		_healthBar.fillAmount = 1f / _playerHealth * _health;
		if (_health <= 0) {
			_healthBar.fillAmount = 0;
		}
	}

	public void TakeDamage(int damage, GameObject go, Animator anim) {
		DecreaseHealth (damage, go, anim);
	}
}
