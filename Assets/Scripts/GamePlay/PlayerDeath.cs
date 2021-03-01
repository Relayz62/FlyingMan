using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private Canvas _deathCanvas;
    [SerializeField] private GameStates _gameStates;

    public void PlayerDead()
    {
        _gameStates.EndGame(true);
        _deathCanvas.enabled = true;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
