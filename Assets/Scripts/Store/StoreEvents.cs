using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreEvents : MonoBehaviour
{
    [SerializeField] private Store _store;
    [SerializeField] private StoreSlots[] _storeSlots;

    private void Start()
    {
        _store.onStoreChangedCallback?.Invoke();
    }
    private void OnEnable()
    {
        _store.onStoreChangedCallback += LoadItems;
    }
    private void OnDisable()
    {
        _store.onStoreChangedCallback -= LoadItems;
    }


    private void LoadItems()
    {
        for (int i = 0; i < _storeSlots.Length; i++)
        {
            if (i < _store.storeEntity.Count)
            {
                _storeSlots[i].AddItem(_store.storeEntity[i]);
            }
            else
            {
                _storeSlots[i].ClearSlot();
            }
        }
    }


}
