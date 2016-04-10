using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponEquip : MonoBehaviour
{
	private bool _hasWeapon;
	private Animator _anim;
	GameObject _equippedWeapon;
	PlayerInventory _playerInventory;
	Craftables _craftables = new Craftables();
    [SerializeField]private List<GameObject> _weapons = new List<GameObject>();
    [SerializeField]private GameObject _weaponSpawnPoint;

	public GameObject EquipedWeapon {
		get { 
			return _equippedWeapon;
		}
	}
	public bool HasWeapon {
		get { 
			return _hasWeapon;
		}
	}

    void Awake()
    {
		_playerInventory = GetComponent < PlayerInventory> ();
		_anim = GetComponent<Animator> ();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))//bird pick axe
        {
			int id = 0;
			ItemData itemData = _craftables.BirdPickAxe;
//
			ItemData playerItem = new ItemData(_playerInventory.PlayerItems[id].Wood, 
				_playerInventory.PlayerItems[id].Rope, 
				_playerInventory.PlayerItems[id].BearFur, 
				_playerInventory.PlayerItems[id].DuckFur, 
				_playerInventory.PlayerItems[id].BirdFur, 
				_playerInventory.PlayerItems[id].Bones);
//
			if (playerItem.BearFur == itemData.BearFur &&
				playerItem.BirdFur == itemData.BirdFur &&
				playerItem.Bones == itemData.Bones &&
				playerItem.DuckFur == itemData.DuckFur &&
				playerItem.Rope == itemData.Rope && 
				playerItem.Wood == itemData.Wood) 
			{
				
				_weapons [0].transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
				_equippedWeapon = _weapons [0];
				_anim.SetBool ("WeaponEquipedBirdWeapon", true);
				_anim.SetBool ("WeaponEquipedDuckWeapon", false);
				_anim.SetBool ("Idle", true);
				_hasWeapon = true;
			} 
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
			int id = 1;
			ItemData itemData = _craftables.DuckClub;

			ItemData playerItem = new ItemData(_playerInventory.PlayerItems[id].Wood, 
				_playerInventory.PlayerItems[id].Rope, 
				_playerInventory.PlayerItems[id].BearFur, 
				_playerInventory.PlayerItems[id].DuckFur, 
				_playerInventory.PlayerItems[id].BirdFur, 
				_playerInventory.PlayerItems[id].Bones);

			if (playerItem.BearFur == itemData.BearFur &&
			    playerItem.BirdFur == itemData.BirdFur &&
			    playerItem.Bones == itemData.Bones &&
			    playerItem.DuckFur == itemData.DuckFur &&
			    playerItem.Rope == itemData.Rope &&
			    playerItem.Wood == itemData.Wood) 
			{

				_weapons [1].transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
				_anim.SetBool ("WeaponEquipedDuckWeapon", true);
				_anim.SetBool ("WeaponEquipedBirdWeapon", false);
				_anim.SetBool ("Idle", true);
				_equippedWeapon = _weapons [1];
				_hasWeapon = true;
			} 
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
			_weapons[2].SetActive(true);
			_weapons [2].transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			_equippedWeapon = _weapons[2];
        }
	}
}
