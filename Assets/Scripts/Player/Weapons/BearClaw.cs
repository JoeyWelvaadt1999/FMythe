using UnityEngine;
using System.Collections;

public class BearClaw : MonoBehaviour, IWeapon
{
	[SerializeField]private int _damage;
    public void Attack()
    {
        Debug.Log("attacking with the bear claw. Scratch scratch scratch!");
    }

	public int Damage() {
		return _damage;
	}
}
