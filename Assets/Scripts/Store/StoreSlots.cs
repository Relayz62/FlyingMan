using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreSlots : MonoBehaviour
{
    public Image slotIcon;
    public StoreEntity _storeEntity;

    public void AddItem(StoreEntity newStoreEntity)
    {
        _storeEntity = newStoreEntity;
        slotIcon.sprite = newStoreEntity.Icon;
    }
    public void ClearSlot()
    {
        _storeEntity = null;
        slotIcon.sprite = null;
    }
}
