using UnityEngine;
using System.Collections;

public enum LookDirection
{
	Right,
	Left,
	None
}

public class EnemyMovement : MonoBehaviour {
	Animator _anim;
	private bool _facingRight;
	private Vector3 _walkToPos;
	private Vector3 _currentPos;
	private Vector3 _scale;
	private LookDirection _lookDirection = LookDirection.None;
	private EnemyFollow _enemyFollow;
	private EnemyStates _enemyStates;
	private Transform _playerTarget;
	private bool _idle;
	[SerializeField]private float _speed;

    void Awake()
    {
		_scale = transform.localScale;
		_enemyStates = GetComponent<EnemyStates> ();
		_enemyStates.states = States.Wander;
        _anim = GetComponent<Animator>();

		_enemyFollow = GetComponent<EnemyFollow> ();
		_playerTarget = _enemyFollow.PlayerTarget;
    }

	void Update() {
		Wander ();
	}

	void Wander() {
		if (_enemyStates.states == States.Wander) {
			CheckLookDirection ();
			if (_currentPos == Vector3.zero || _currentPos == _walkToPos && !_idle) {
				_anim.SetBool ("isWalking", true);
				_walkToPos = new Vector3 (Random.Range (-36f, 36f), Random.Range (-40f, 40f), 0);
				_idle = true;
			}

			_currentPos = transform.position;
			
			transform.position = Vector3.MoveTowards (_currentPos, _walkToPos, _speed / 100);

			if (_currentPos == _walkToPos) {
				StartCoroutine (Idle());
			}
		}

	}

	public void CheckLookDirection() {
		Vector3 newEnemyScale = transform.localScale;
		if (_walkToPos.x > transform.position.x) {
			
				newEnemyScale.x = -_scale.x;


		} else if (_walkToPos.x < transform.position.x) {
			
				newEnemyScale.x = _scale.x; 

		}

		transform.localScale = newEnemyScale;
		_lookDirection = LookDirection.None;
	}

	IEnumerator Idle() {
		_anim.SetBool ("Idle", true);
		while (_anim.GetAnimatorTransitionInfo (0).IsName ("IdleSpecial")) {
			yield return new WaitForSeconds (0);
		}
		_idle = false;
	}
}
