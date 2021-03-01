using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyPicked : MonoBehaviour
{
    [SerializeField] private Text _moneyText;
    private int _pMoney;
    [SerializeField] private TriggerEnter _triggerEnter;
    [SerializeField] private PlayerStats _playerStats;

    private void Start()
    {
        _pMoney = PlayerPrefsSafe.GetInt("pMoney");
        _moneyText.text = _pMoney.ToString();
    }
    private void OnEnable()
    {
        _triggerEnter.moneyPickedEvent += GiveMoney;
    }

    private void OnDisable()
    {
        _triggerEnter.moneyPickedEvent -= GiveMoney;
    }

    private void GiveMoney()
    {
        _playerStats.SetStats(PlayerStats.pStats.pMoney, _pMoney+10);
        _playerStats.GetStats(PlayerStats.pStats.pMoney, ref _pMoney);
        _moneyText.text = _pMoney.ToString();
    }
}
