using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CraftableObject : MonoBehaviour {
	[SerializeField]private Text _neededResources;
	private List<ItemData> _itemDatas = new List<ItemData>();
	private Craftables _craftables = new Craftables();

	private ItemData _birdPickAxe;
	private ItemData _duckClub;
	private ItemData _rope;

	private PlayerCraft _playerCraft;
	private PlayerInventory _playerInventory;

	[SerializeField]private Resource _resource;
	[SerializeField]private Image _image;
	[SerializeField]private Image _effect;

	[SerializeField]private int _id;

	void Start() {
		_neededResources.gameObject.SetActive (false);
		_effect.gameObject.SetActive( false);


		_birdPickAxe = _craftables.BirdPickAxe;
		_duckClub = _craftables.DuckClub;
		_rope = _craftables.Rope;

		_itemDatas.Add (_birdPickAxe);//ID 0
		_itemDatas.Add(_duckClub);//ID 1
		_itemDatas.Add(_rope);//ID 2

		_playerCraft = FindObjectOfType<PlayerCraft> ();
		_playerInventory = FindObjectOfType<PlayerInventory> ();
	}

	public void CraftObject() {
		_effect.gameObject.SetActive( true);
		_playerCraft.CraftItem (_itemDatas[_id], _image);
	}

	public void CraftResource() {
		_effect.gameObject.SetActive (true);
		_playerCraft.CraftResource (_resource, true, _itemDatas[_id]);
	}

	public void SetParent() {
		Color c = _image.color;
		c.a = 1 ;
		_image.color = c;
		_image.sprite = GetComponent<Image>().sprite;
		_neededResources.gameObject.SetActive (true);
	}

	public void ResetParent() {
		Color c = _image.color;
		c.a = 0;
		_image.color = c;
		_effect.gameObject.SetActive( false);
		_neededResources.gameObject.SetActive (false);
	}
}
