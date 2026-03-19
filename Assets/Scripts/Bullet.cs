using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Cấu hình di chuyển")]
    public float flySpeed = 10f; 

    [Header("Cấu hình sức mạnh")]
    public int damage = 1; // Khai báo biến sát thương

    void Update()
    {
       
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
       
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (!collision.CompareTag("Player"))
        {
         
            Health targetHealth = collision.GetComponent<Health>();

            if (targetHealth != null)
            {
                
                targetHealth.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}