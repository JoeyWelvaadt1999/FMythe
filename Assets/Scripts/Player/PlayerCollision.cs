using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
	private bool _canTakeDamage = true;
    private PlayerHealth _playerHealth;
    private PlayerDeath _playerDeath;
    private PlayerRespawn _playerRespawn;

    void Awake()
    {
        _playerHealth = GetComponent<PlayerHealth>();
        _playerDeath = GetComponent<PlayerDeath>();
        _playerRespawn = FindObjectOfType<PlayerRespawn>();
    }

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.transform.tag == LayerTags.enemy && coll.gameObject.layer == LayerMask.NameToLayer(LayerTags.offenseLayer) && gameObject.layer == LayerMask.NameToLayer(LayerTags.defenseLayer)) {
			if (_canTakeDamage) {
				_playerHealth.TakeDamage (coll.GetComponentInParent<EnemyAttack> ().Damage, transform.gameObject, GetComponent<Animator>());
//				_canTakeDamage = false;
				Debug.Log(_playerHealth.Health);

			}
		}
	}

	void OnTriggerExit2D (Collider2D coll) {
//		Ddebug.Log ("Exit");
//		if (coll.transform.tag == LayerTags.enemy && coll.transform.gameObject.layer == LayerMask.GetMask(LayerTags.offenseLayer)) {
			_canTakeDamage = true;
//		}
	}
}
