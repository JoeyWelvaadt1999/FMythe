using UnityEngine;
using System.Collections;

public class Spear : MonoBehaviour, IWeapon
{
	[SerializeField]private int _damage;
    public void Attack()
    {
        Debug.Log("attacking with spear. Stabby stab stab");
    }

	public int Damage() {
		return _damage;
	}
}
