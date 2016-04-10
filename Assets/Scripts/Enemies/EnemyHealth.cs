using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnemyHealth : LifePoints
{
	[SerializeField]private Image _healthBar;
	[SerializeField]private int _enemyHealth;
	void Awake () {
		_health = _enemyHealth;
		TakeDamage (0, this.gameObject, GetComponent<Animator> ());
	}

	void Update() {
		_healthBar.fillAmount = 1f / _enemyHealth * _health;
		if (_health <= 0) {
			_healthBar.fillAmount = 0;
		}
	}

	public void TakeDamage(int damage, GameObject go, Animator anim) {
		DecreaseHealth (damage, go, anim);
	}
}
