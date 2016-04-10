using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCraft : MonoBehaviour
{
    private Craftables _craftables = new Craftables();
	private PlayerInventory _playerInventory;//Variable to PlayerInventory component 
	private Resources _resources;//Empty variable, will be used to store Recourses from te PlayerInventory component

	// Use this for initialization
	void Start ()
    {
		_playerInventory = GetComponent<PlayerInventory> ();//Use GetComponent to get the PlayerInventory component from the player object
		_resources = _playerInventory.PlayerResources;//Put the recources from the PlayerInventory component in the recourses variable in this component
		//Be aware that this needs to be updated incase the player pick's up a new recourse
//        print("Resources required to make a torch : " + "Wood: "+ _craftables.Torch.wood + " Stones: " + _craftables.Torch.stones);
//        print("Resources required to make a fur coat" + _craftables.FurCoat.fur);
        
	}

	public void CraftItem(ItemData id, Image _image)
    {
		_resources = _playerInventory.PlayerResources;
		 
		if (!_playerInventory.PlayerItems.Contains (id)) {
			_playerInventory.AddToList (id);
			if (_resources.BearFur >= id.BearFur && _resources.BirdFur >= id.BirdFur && _resources.DuckFur >= id.DuckFur && _resources.Wood >= id.Wood && _resources.Rope >= id.Rope && _resources.Bone >= id.Bones) {
				_resources.BearFur -= id.BearFur;
				_resources.BirdFur -= id.BirdFur;
				_resources.DuckFur -= id.DuckFur;
				_resources.Bone -= id.Bones;
				_resources.Wood -= id.Wood;
				_resources.Rope -= id.Rope;
				InventorySlot[] inventorySlots = FindObjectsOfType<InventorySlot> ();
				foreach (InventorySlot slot in inventorySlots) {
					if (slot.HasItem) {
						switch (slot.Type) {
						case ResourceTypes.ResourceType._bearFur:
							slot.SetCount (_resources.BearFur);
							break;
						case ResourceTypes.ResourceType._birdFur:
							slot.SetCount (_resources.BirdFur);
							break;
						case ResourceTypes.ResourceType._duckFur:
							slot.SetCount (_resources.DuckFur);
							break;
						case ResourceTypes.ResourceType._rope:
							slot.SetCount (_resources.Rope);
							break;
						case ResourceTypes.ResourceType._bone:
							slot.SetCount (_resources.Bone);
							break;
						case ResourceTypes.ResourceType._wood:
							slot.SetCount (_resources.Wood);
							break;
						default:
							break;
						}
					}
				}
				FindObjectOfType<InventoryBar> ().CheckForItem (_image.sprite);
					
			}
		}
    }

	void Set() {
		
	}

	public void CraftResource(Resource _resource, bool _crafted, ItemData id) {
		if (_resources.BearFur >= id.BearFur && _resources.BirdFur >= id.BirdFur && _resources.DuckFur >= id.DuckFur && _resources.Wood >= id.Wood && _resources.Rope >= id.Rope && _resources.Bone >= id.Bones) {
			Instantiate (_resource.gameObject, GameObject.FindWithTag ("Player").transform.position, Quaternion.identity);
			_resources.BearFur -= id.BearFur;
			_resources.BirdFur -= id.BirdFur;
			_resources.DuckFur -= id.DuckFur;
			_resources.Bone -= id.Bones;
			_resources.Wood -= id.Wood;
			_resources.Rope -= id.Rope;
			InventorySlot[] inventorySlots = FindObjectsOfType<InventorySlot> ();
			foreach (InventorySlot slot in inventorySlots) {
				if (slot.HasItem) {
					switch (slot.Type) {
					case ResourceTypes.ResourceType._bearFur:
						slot.SetCount (_resources.BearFur);
						break;
					case ResourceTypes.ResourceType._birdFur:
						slot.SetCount (_resources.BirdFur);
						break;
					case ResourceTypes.ResourceType._duckFur:
						slot.SetCount (_resources.DuckFur);
						break;
					case ResourceTypes.ResourceType._rope:
						slot.SetCount (_resources.Rope);
						break;
					case ResourceTypes.ResourceType._bone:
						slot.SetCount (_resources.Bone);
						break;
					case ResourceTypes.ResourceType._wood:
						slot.SetCount (_resources.Wood);
						break;
					default:
						break;
					}
				}
			}
		}

	}

	void Update ()
    {
//       CraftItem();   
	}
}
