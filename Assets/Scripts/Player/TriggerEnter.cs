using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        if(collider.CompareTag("Coin"))
        {

        }
    }
}

