using UnityEngine;
using System.Collections;

public enum States {
	Attacking,
	Wander,
	Chasing,
	None
}

public class EnemyStates : MonoBehaviour {
	private States _states = States.None;
	public States states {
		get { 
			return _states;
		} set { 
			_states = value;
		}
	}
}
