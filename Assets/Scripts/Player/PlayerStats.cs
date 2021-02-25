using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public enum pStats { pMoney, pDonate, pScore }; // Набор именованных констант
    public pStats PlayerData { get; set; } // Свойство

    private int _pMoney; // поле денег
    private int _pDonate; // поле доната
    private int _pScore; // поле очков

    //Метод, который задаёт значение полям
    //Вх.данные: Перечисления, значения целого типа
    public void SetStats(pStats stats, int value)
    {
        switch(stats)
        {
            case pStats.pMoney:
                _pMoney = value;
                PlayerPrefsSafe.SetInt("pMoney", _pMoney);
                break;
            case pStats.pDonate:
                _pDonate = value;
                PlayerPrefsSafe.SetInt("pDonate", _pDonate);
                break;
            case pStats.pScore:
                _pScore = value;
                PlayerPrefsSafe.SetInt("pScore", _pScore);
                break;
        }
    }
    //Получение данных
    //Вх.Данные: Перечисления, значение целого типа
    //Вх.данные: значение целого типа
    public void GetStats(pStats stats, ref int value)
    {
        switch (stats)
        {
            case pStats.pMoney:
                value = PlayerPrefsSafe.GetInt("pMoney");
                break;
            case pStats.pDonate:
                value = PlayerPrefsSafe.GetInt("pDonate");
                break;
            case pStats.pScore:
                value = PlayerPrefsSafe.GetInt("pScore");
                break;
        }
    }
}
