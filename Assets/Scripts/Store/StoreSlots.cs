using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class StoreSlots : MonoBehaviour, IPointerClickHandler
{
    public Image slotIcon;
    public StoreEntity _storeEntity;
    public enum Accses { Locked, Opened }
    public Accses accsesType { get; set; }
    public GameObject slotModel;
    public int slotID;
    [SerializeField] private PlayerClothes _playerClothes;


    public void AddItem(StoreEntity newStoreEntity)
    {
        _storeEntity = newStoreEntity;
        slotIcon.sprite = newStoreEntity.Icon;
        accsesType = (Accses)newStoreEntity.accsesType;
        slotModel = newStoreEntity.Model;
        slotID = newStoreEntity.ID;
    }
    public void ClearSlot()
    {
        _storeEntity = null;
        slotIcon.sprite = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _playerClothes.WearClothes(this);
    }
}
