using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
	Animator _anim;
	[SerializeField]private int _damage;
	[SerializeField]private Vector2 _attackRange;
	public Vector2 AttackRange {
		get { 
			return _attackRange;
		}	
	}
	public int Damage {
		get { 
			return _damage;
		}
	}
	private PlayerHealth _playerHealth;
	private GameObject _player;
	private EnemyFollow _enemyFollow;
	private EnemyStates _enemyStates;
	private bool _isAttacking;

	public bool IsAttacking {
		get { 
			return _isAttacking;
		} set { 
			_isAttacking = value;
		}
	}

	void Awake () {
		_enemyStates = GetComponent<EnemyStates> ();
		_player = GameObject.FindGameObjectWithTag ("Player");
		_playerHealth = _player.GetComponent<PlayerHealth> ();
		_enemyFollow = GetComponent<EnemyFollow> ();
		_anim = GetComponent<Animator> ();
	}

	void Update () {
		Attack ();
	}

	public void Attack() {
		if (InRange()) {
            _isAttacking = true;
			_enemyStates.states = States.Attacking;
			_enemyFollow.ChangeLookDirection ();

			_anim.SetBool ("isWalking", false);
			_anim.SetBool ("isAttacking", true);

		} else {
			
			if (_enemyStates.states != States.Wander) {
				
				if (!_anim.GetCurrentAnimatorStateInfo (0).IsName("Attack")) {
					_anim.SetBool ("isAttacking", false);
					_anim.SetBool ("isWalking", true);
					_enemyStates.states = States.Chasing;
				}
			}
		}
	}

	public bool InRange() {
		float dx = Mathf.Abs(transform.position.x - _enemyFollow.PlayerTarget.position.x);
		float dy = Mathf.Abs(transform.position.y - _enemyFollow.PlayerTarget.position.y);	
		if (dx <= _attackRange.x / 2 && dy <= _attackRange.y / 2) {
			return true;
		} else {
			return false;
		}
	}
		
}
