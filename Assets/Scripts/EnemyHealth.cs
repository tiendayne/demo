using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : Health
{
    protected override void Die()
    {
        
        if (explosionPrefab != null) {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }

        base.Die(); 
        Debug.Log("Enemy died");
        Destroy(gameObject);
    }
}