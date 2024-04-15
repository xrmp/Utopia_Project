using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestSpiritInteraction : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ForestSpirit"))
        {
            DisableWall();  // Perform actions when the forest spirit enters the wall's zone
        }
    }

    private void DisableWall()
    {
        // Add code here to disable the wall
        // For example:
        gameObject.SetActive(false);
    }
}