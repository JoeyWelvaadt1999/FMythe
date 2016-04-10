using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour
{
	private Animator _anim;
	private EnemyAttack _enemyAttack;
	private EnemyStates _enemyStates;
	private Vector3 _scale;
    [SerializeField]private float _radius;
    private int _layermask;
    private Transform _playerTarget;
	public Transform PlayerTarget {
		get { 
			return _playerTarget;
		}
	}
    [SerializeField]private float followSpeed;
	private bool _facingRight;

	void Awake() {
		_scale = transform.localScale;
		_playerTarget = GameObject.FindWithTag ("Player").transform;
		_anim = GetComponent <Animator> ();
		_enemyAttack = GetComponent<EnemyAttack> ();
		_enemyStates = GetComponent<EnemyStates> ();
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(this.transform.position, _radius);
		if(Application.isPlaying)
			Gizmos.DrawWireCube(transform.position, new Vector3(_enemyAttack.AttackRange.x, _enemyAttack.AttackRange.y, 0));
    }	

    void FollowPlayerTarget()
	{
		if (_enemyStates.states != States.Attacking) {
			if (Vector2.Distance (transform.position, _playerTarget.position) <= _radius && !_enemyAttack.InRange ()) {
				ChangeLookDirection ();
				Vector2 heading = _playerTarget.transform.position - transform.position;
				float distance = heading.magnitude;
				Vector2 direction = heading / distance;

				transform.Translate (direction * Time.deltaTime * followSpeed);

				_anim.SetBool ("isWalking", true);
				_enemyStates.states = States.Chasing;
			} else {
				if (_enemyStates.states != States.Wander) {
					
					GetComponent<EnemyMovement> ().CheckLookDirection ();
					_enemyStates.states = States.Wander;
				}
			}
		}
    }

	public void ChangeLookDirection() {
		
		Vector3 tScale = transform.localScale;
		if(_playerTarget.position.x > transform.position.x){
			
				tScale.x = -_scale.x;


				
		} 
		if (_playerTarget.position.x < transform.position.x) {
			
				tScale.x = _scale.x;


		}

		transform.localScale = tScale;
	}

    void Update ()
	{
		if (_enemyStates.states == States.Chasing) {
			ChangeLookDirection ();
		}
		FollowPlayerTarget();
	}
}
