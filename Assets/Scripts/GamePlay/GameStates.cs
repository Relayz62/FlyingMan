﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates : MonoBehaviour
{
    [SerializeField] private UIController _uiContrl; // Управление UI
    [SerializeField] private PlayerTouchControl _playerContrl; // управление персонажем
    public enum GameState { Start,Play, Pause, End } // Состояния игры
    public GameState gameState { get; private set; } // Свойства гэймСтэйта.

    private void Start()
    {
        gameState = GameState.Start;
    }

    private void Update()
    {
       
    }

    public void StartGame(bool start)
    {
        if (start)
        {
            gameState = GameState.Play;
            _playerContrl.enabled = true;
        }
    }

    public void EndGame(bool loose)
    {
        if (loose) gameState = GameState.End;
    }

}
