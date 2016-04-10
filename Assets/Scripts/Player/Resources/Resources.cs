using UnityEngine;
using System.Collections;

public class Resources {
	private int _wood;
	private int _birdFur;
	private int _bearFur;
	private int _duckFur;
	private int _rope;
	private int _bone;

	private int _max = 10;

	public int Wood {
		get { 
			return _wood;
		}

		set {
			if (_wood < _max) {
				_wood = value;
				if (_wood > _max) {
					_wood = _max;
				}
			}

		}
	}

	public int BirdFur {
		get { 
			return _birdFur;
			}

		set {
			if (_birdFur < _max) {
				_birdFur = value;
				if (_birdFur > _max) {
					_birdFur = _max;
				}
			}
		}
	}

	public int BearFur {
		get { 
			return _bearFur;
			}

		set {
			if (_bearFur < _max) {
				_bearFur = value;
				if (_bearFur > _max) {
					_bearFur = _max;
				}
			}
		}
	}

	public int DuckFur {
		get { 
			return _duckFur;
			}

		set {
			if (_duckFur < _max) {
				_duckFur = value;
				if (_duckFur > _max) {
					_duckFur = _max;

				}
			}
		}
	}

	public int Rope {
		get { 
			return _rope;
		}

		set {
			if (_rope < _max) {
				_rope = value;
				if (_rope > _max) {
					_rope = _max;

				}
			}
		}
	}

	public int Bone {
		get { 
			return _bone;
		}

		set {
			if (_bone < _max) {
				_bone = value;
				if (_bone > _max) {
					_bone = _max;

				}
			}
		}
	}
}

[System.Serializable]
public struct ResourceTypes
{
	public enum ResourceType
	{
		_none,
		_wood,
		_birdFur,
		_bearFur,
		_duckFur,
		_rope,
		_bone,
		_other
	};
}

