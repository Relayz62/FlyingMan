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
            other.transform.position = new Vector3(other.transform.position.x, 0, other.transform.position.z);
            onScoreUpdated?.Invoke();
        }
    }
}
