using UnityEngine;
using System.Collections;

public class PlayerMeleeAttack : MonoBehaviour
{
	Animator _anim;
	WeaponEquip _weaponEquip;
    bool _attacking = false;
	[SerializeField]private int _damage;
	// Use this for initialization
	void Start ()
    {
		_anim = GetComponent<Animator> ();
		_weaponEquip = GetComponent<WeaponEquip> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) && !_attacking && _weaponEquip.HasWeapon) {
			GetComponent<PlayerMovement> ().enabled = false;
//			_anim.SetFloat ("Speed", 0);
			_attacking = true;
			StartCoroutine (Attacking());
			_anim.SetBool("Attacking", true);
			_weaponEquip.EquipedWeapon.GetComponent<Animator> ().SetBool ("isAttacking", true);
			_weaponEquip.EquipedWeapon.GetComponent<Animator> ().enabled = true;
		}	
	}

	public int Damage() {
		if (_attacking) {
			_attacking = false;
			return _weaponEquip.EquipedWeapon.GetComponent<IWeapon>().Damage();
		} else {
			return 0;
		}
	}

	IEnumerator Attacking() {
		while (_weaponEquip.EquipedWeapon.GetComponent<Animator> ().GetBool("isAttacking")) {
			if (_weaponEquip.EquipedWeapon.GetComponent<PolygonCollider2D> () == null) {
				_weaponEquip.EquipedWeapon.AddComponent<PolygonCollider2D> ();
				_weaponEquip.EquipedWeapon.GetComponent<PolygonCollider2D> ().isTrigger = true;
			} else {
				Destroy (_weaponEquip.EquipedWeapon.GetComponent<PolygonCollider2D> ());
			}
//			_anim.SetFloat ("Speed", 0);
			Debug.Log ("Is playing");
			yield return 0;
		} 
		GetComponent<PlayerMovement> ().enabled = true;
		_anim.SetBool("Attacking", false);
		_attacking = false;
		Debug.Log ("Stopped playing");

	}
}
