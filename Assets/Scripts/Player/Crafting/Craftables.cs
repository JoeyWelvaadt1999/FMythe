using UnityEngine;
using System.Collections;

public class Craftables
{
	ItemData _birdPickAxe = new ItemData(2,1,0,0,3,0);
	ItemData _duckClub = new ItemData(4, 2, 0, 4, 0, 0);
	ItemData _rope = new ItemData (2, 0, 0, 0, 0, 2);
//	ItemData _duckSpear = new ItemData();

    public ItemData BirdPickAxe
    {
        get
        {
			return _birdPickAxe;
        }
    }
		
	public ItemData DuckClub {
		get {
			return _duckClub;
		}
	}

	public ItemData Rope {
		get { 
			return _rope;
		}
	}
}
