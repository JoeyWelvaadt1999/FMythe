using UnityEngine;
using System.Collections;

public class BirdWeapon : MonoBehaviour, IWeapon {
	[SerializeField]private int _damage;

	public void Attack(){
		

	

	}

	public int Damage() {
		return _damage;
	}
}
