using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapToStart : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameStates _gameStates; // состояние игры
    [SerializeField] private Transform _player; // трансформ игрока
    [SerializeField] private Camera _camFly; // камера, которая следит за игроком в полёте
    [SerializeField] private PlayerAnimation _playerAnim; // анимации
    [SerializeField] private UIController _uIController;
    [SerializeField] private GameObject _tapToStartPanel;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.clickCount == 1)
        {           
            StartCoroutine(nameof(JumpingOnStart));
        }
    }
    private IEnumerator JumpingOnStart()
    {
        _uIController.ClearText();
        _playerAnim.SetAnimationBool("Jump", true);
        yield return new WaitForSecondsRealtime(1f);
        _gameStates.StartGame(true);
        _playerAnim.SetAnimationBool("Fly", true);
        _player.transform.position = new Vector3(0, 0, 0);
        _player.transform.rotation = Quaternion.Euler(0, 90, 0);
        _camFly.enabled = true;
        _tapToStartPanel.SetActive(false);
        
    }
}
