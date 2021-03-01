using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ReloadZone : MonoBehaviour
{
    public UnityAction onScoreUpdated;
    [SerializeField] private MapGeneration _mapGeneration;
    public UnityAction OnMapGenerated;
    public UnityAction OnMapClear;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = new Vector3(other.transform.position.x, 0, other.transform.position.z);
            onScoreUpdated?.Invoke();
            OnMapClear?.Invoke();
            OnMapGenerated?.Invoke();
            
        }
    }
}
