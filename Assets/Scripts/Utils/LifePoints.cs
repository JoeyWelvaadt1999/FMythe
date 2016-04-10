using UnityEngine;
using System.Collections;

public class LifePoints : MonoBehaviour
{
	private PlayerRespawn _playerRespawn;
	protected int _health;
	public int Health {
		get { 
			return _health;
		}
	}

	void Start () {
		_playerRespawn = FindObjectOfType<PlayerRespawn> ();
	}

	protected void DecreaseHealth (int damage, GameObject go, Animator anim) {
		_health -= damage;


		if (_health <= 0) {
			if (go.tag == LayerTags.enemy) {
					
				anim.SetBool ("isDeath", true);
				GetComponent<EnemyAttack> ().enabled = false;
				GetComponent<EnemyCollision> ().enabled = false;
				GetComponent<EnemyFollow> ().enabled = false;
				FindObjectOfType<BossSpawning>().IncreaseBar();
				GetComponent<EnemyMovement> ().enabled = false;
				GetComponent<EnemyStates> ().enabled = false;
			}

			if(go.gameObject.tag == LayerTags.player)
				StartCoroutine(_playerRespawn.WaitForRespawn(_playerRespawn.RespawnTime));				
		}
	}
}
