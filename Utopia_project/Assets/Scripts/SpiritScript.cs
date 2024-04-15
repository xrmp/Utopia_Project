using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritScript : MonoBehaviour
{
    public float destroyRadius = 5f;

    void Update()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, destroyRadius);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Obstacle"))
            {
                Destroy(collider.gameObject);
            }
        }
    }
}