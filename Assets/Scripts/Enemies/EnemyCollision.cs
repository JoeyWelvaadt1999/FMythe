using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{
    private EnemyHealth _enemyHealth;

    void Awake()
    {
        _enemyHealth = GetComponentInParent<EnemyHealth>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
//		Debug.Log (collider.gameObject.name);
		if (collider.gameObject.tag == LayerTags.weapon && gameObject.layer == LayerMask.NameToLayer(LayerTags.defenseLayer) && collider.gameObject.layer == LayerMask.NameToLayer(LayerTags.offenseLayer))
        {
			print("Enemy health: " + _enemyHealth.Health);
			_enemyHealth.TakeDamage (collider.gameObject.GetComponentInParent<PlayerMeleeAttack> ().Damage(), transform.gameObject, GetComponent<Animator>());
        }
    }
}
