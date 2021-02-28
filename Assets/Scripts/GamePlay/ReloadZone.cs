using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReloadZone : MonoBehaviour
{
    public UnityAction onScoreUpdated;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(0, 0, 0);
            onScoreUpdated?.Invoke();
        }
    }
}
