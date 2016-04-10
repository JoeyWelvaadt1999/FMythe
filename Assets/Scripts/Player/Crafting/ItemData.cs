using UnityEngine;
using System.Collections;

public class ItemData
{
	private int wood;
	private int rope;
	private int bearFur;
	private int duckFur;
	private int birdFur;
	private int bones;

	public ItemData(int _wood, int _rope, int _bearFur, int _duckFur, int _birdFur, int _bones)
    {
        wood = _wood;
		rope = _rope;
		bearFur = _bearFur;
		duckFur = _duckFur;
		birdFur = _birdFur;
		bones = _bones;
    }

	public int Wood {
		get { 
			return wood;
		}
	}

	public int Rope {
		get { 
			return rope;
		}
	}

	public int BearFur {
		get { 
			return bearFur;
		}
	}

	public int DuckFur {
		get { 
			return duckFur;
		}
	}

	public int BirdFur {
		get { 
			return birdFur;
		}
	}

	public int Bones {
		get { 
			return bones;
		}
	}
}
