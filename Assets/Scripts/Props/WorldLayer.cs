using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorldLayer : MonoBehaviour {
	private SpriteRenderer _transformSprite;
	private GameObject[] _enemies;
	private GameObject[] _enemyChild;
	private List<SpriteRenderer> _enemySprites = new List<SpriteRenderer>();
	// Use this for initialization
	void Start () {
//		_enemies = new GameObject[FindObjectsOfType<EnemyMovement> ().Length];
//		for(int y = 0; y < _enemies.Length; y++) {
//			_enemies[y] = FindObjectsOfType<EnemyMovement>()[y].gameObject;
//			Debug.Log (_enemies [y].name);
//		}
//
//		_enemyChild = new GameObject[_enemies.Length];
//		for (int x = 0; x < _enemies.Length; x++) {
//			_enemyChild [x] = _enemies [x].transform.FindChild ("LayerTransform").gameObject;
//		}
//		_transformSprite = GetComponent<SpriteRenderer> ();
//		for (int i = 0; i < _enemies.Length; i++) {
//			for (int j = 0; j < _enemies[i].GetComponentsInChildren<SpriteRenderer>().Length; j++) {
//				_enemySprites.Add (_enemySprites[i].GetComponentsInChildren<SpriteRenderer>()[j]);
//			}
//		}
	}
	
	// Update is called once per frame
	void Update () {
//		for (int i = 0; i < _enemySprites.Count; i++) {
//			for (int j = 0; j < _enemyChild.Length; j++) {
//				if (_enemyChild [j].transform.position.y < transform.position.y) {
//					_enemySprites [i].sortingOrder = _transformSprite.sortingOrder + 1;
//				} else {
//					_enemySprites [i].sortingOrder = _transformSprite.sortingOrder - 1;
//				}
//			}
//		}
	}
}
