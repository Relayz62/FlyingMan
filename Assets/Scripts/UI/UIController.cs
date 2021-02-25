using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _tapToStart;


    public void ClearText()
    {
        _tapToStart.SetActive(false);
    }
}
