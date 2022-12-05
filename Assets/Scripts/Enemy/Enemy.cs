using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Cake cake))
        {
            Die();
        }
    }

    private void Die() 
    {
        Destroy(gameObject);
    }
}
