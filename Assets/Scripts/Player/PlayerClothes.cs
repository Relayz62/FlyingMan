using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothes : MonoBehaviour
{
    [SerializeField] private List<GameObject> clothes = new List<GameObject>();
    private int index;

    public void WearClothes(StoreSlots storeSlots)
    {
        index = storeSlots.slotID;
        if(storeSlots.accsesType == StoreSlots.Accses.Opened)
        {
            clothes[index] = Instantiate(storeSlots.slotModel, clothes[index].transform);
        }
    }
}
