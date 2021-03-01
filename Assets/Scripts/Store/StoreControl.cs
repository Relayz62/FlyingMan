using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreControl : MonoBehaviour
{
    public GameObject TapToStart; // убираем тэп ту старт
    public Canvas StoreCanvas; // магазин
    [SerializeField] private Camera _storeCam; // камера в магазине
    [SerializeField] private GameObject _stand;
    [SerializeField] private UIController _UICtrl;
    private bool isStoreOpen;


    private void FixedUpdate()
    {
        if(isStoreOpen) RotateStand();
    }

    private void RotateStand()
    {
        _stand.transform.Rotate(new Vector3(0, 30, 0) * Time.fixedDeltaTime);
    }

    public void OpenStore()
    {
        _storeCam.enabled = true;
        TapToStart.SetActive(false);
        isStoreOpen = true;
        StoreCanvas.enabled = true;
        _UICtrl.OnOffCanvas(0);
    }

    public void CloseStore()
    {
        _storeCam.enabled = false;
        TapToStart.SetActive(true);
        isStoreOpen = false;
        StoreCanvas.enabled = false;
        _UICtrl.OnOffCanvas(0);
    }
}
