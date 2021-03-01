using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _tapToStart; // надпись флай ту старт
    [SerializeField] private GameObject _btnStore; // кнопка магазина
    [SerializeField] private Canvas[] _canvasGroup;


    public void HideUI()
    {
        _tapToStart.SetActive(false);
        if (_btnStore.activeSelf == true) _btnStore.SetActive(false);
    }

    public void OnOffCanvas(int canvasIndex)
    {
        if (_canvasGroup[canvasIndex].isActiveAndEnabled) _canvasGroup[canvasIndex].enabled = false;
        else _canvasGroup[canvasIndex].enabled = true;
    }
}
