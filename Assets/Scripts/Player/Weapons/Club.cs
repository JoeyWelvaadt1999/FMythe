using UnityEngine;
using System.Collections;

public class Club : MonoBehaviour, IWeapon
{
	[SerializeField]private int _damage;
    public void Attack()
    {
        Debug.Log("Attacking with the club. smash smash smash");
    }

	public int Damage() {
		return _damage;
	}
}
