using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private int _score;
    [SerializeField] private ReloadZone _reloadZone;

    private void OnEnable()
    {
        _reloadZone.onScoreUpdated += ScoreUpdate;
    }
    private void OnDisable()
    {
        _reloadZone.onScoreUpdated -= ScoreUpdate;
    }
    public void ScoreUpdate()
    {
        _score += 1000;
        _scoreText.text = "Score: " + _score;
    }
}
