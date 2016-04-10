using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class PlayerInventory : MonoBehaviour
{
	[SerializeField]private Text _text;
    private Resource _resourceObject;
    private ResourceTypes.ResourceType _resourceType = new ResourceTypes.ResourceType();
	private Resources _playerResources = new Resources ();
	private List<ItemData> _playerItems = new List<ItemData>();

	public List<ItemData> PlayerItems {
		get { 
			return _playerItems;
		}
	}

    public Resources PlayerResources
    {
        get
        {
            return _playerResources;
        }
    }

    private float _maxDis = 1.5f;

    public void SetState()
    {
        _resourceType = _resourceObject.ResourceType;
        switch (_resourceType)
        {
		case ResourceTypes.ResourceType._bearFur:
			_playerResources.BearFur += _resourceObject.Value;
            break;
		case ResourceTypes.ResourceType._birdFur:
			_playerResources.BirdFur += _resourceObject.Value;
			break;
		case ResourceTypes.ResourceType._duckFur:
			_playerResources.DuckFur += _resourceObject.Value;
			break;
        case ResourceTypes.ResourceType._wood:
        	_playerResources.Wood += _resourceObject.Value;
            break;
		case ResourceTypes.ResourceType._rope:
			_playerResources.Rope += _resourceObject.Value;
			break;
		case ResourceTypes.ResourceType._bone:
			_playerResources.Bone += _resourceObject.Value;
			break;
        }
    }

	void Update() {
		PickupResources (false);
		_text.text = "Press <color=yellow> C </color> To Craft";
	}

	public void PickupResources(bool press)
    {
        Resource[] _resources = FindObjectsOfType<Resource>();
        for (int i = 0; i < _resources.Length; i++)
        {
			if (Vector2.Distance (transform.position, _resources [i].transform.position) < _maxDis) {
				if (press) {
					GetComponent<Animator> ().SetBool ("PickUp", true);
					_resourceObject = _resources [i];
					SetState ();
					FindObjectOfType<InventoryBar> ().CheckForItem (_resources [i], false);
				} 
				_text.text = "Press <color=yellow> B </color> To Grab";
				
			} 
        }
    }

	public void AddToList(ItemData id) {
		_playerItems.Add (id);
	}
}