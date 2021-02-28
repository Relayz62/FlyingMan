using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchControl : MonoBehaviour
{
    [SerializeField] private Transform _player; // Трансформ игрока
    [Range(0,100)]
    [SerializeField] private float _speedForce; // скорость перемещения
    [Range(0, 100)]
    [SerializeField] private float _fallForce; // скорость падения
    private Vector2 _direction; // направление для перемещения
    private Vector2 _startPos; // стартовая точка касания тача
    private bool isDirectionChoose; // проверка идёт ли перемещение
    public Borders borders; // ограничение по перемещению
    public enum ControlType { Touch, Mouse } // выбор управления
    public ControlType cType; // свойство для выбора

    private void FixedUpdate()
    {
        PlayerFalling();
        if(cType == ControlType.Mouse)
        MouseMove();
        else
        TouchMove();
    }

    private void TouchMove()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    _startPos = touch.position;
                    break;
                case TouchPhase.Moved:
                    _direction = touch.position - _startPos;
                    isDirectionChoose = true;
                    break;
                case TouchPhase.Ended:
                    isDirectionChoose = false;
                    break;
            }
        }
        if (isDirectionChoose && _direction.magnitude > 2)
        {
            _player.transform.position = new Vector3(               
               - _direction.x * _speedForce * Time.fixedDeltaTime,
                _player.transform.position.y,
               - _direction.y * _speedForce * Time.fixedDeltaTime);
            
        }
        ///////////////////Borders//////////////////////////////////
        _player.transform.position = new Vector3(
            Mathf.Clamp(_player.transform.position.x, borders.Min_X, borders.Max_X),
            _player.transform.position.y,
             Mathf.Clamp(_player.transform.position.z, borders.Min_Z, borders.Max_Z)
            );
        //////////////////Borders////////////////////////////////////
    }
    private void PlayerFalling()
    {
        var fall = _player.position.y - _fallForce * Time.fixedDeltaTime;
        _player.transform.position = new Vector3(_player.transform.position.x, fall, _player.transform.position.z);
    }

    private void MouseMove()
    {
        Vector3 DirectionMouse;
        if(Input.GetMouseButton(0))
        {
            DirectionMouse = Input.mousePosition / Screen.width *50;
            _player.transform.position = new Vector3(DirectionMouse.x * _speedForce * Time.fixedDeltaTime, _player.transform.position.y, DirectionMouse.y * _speedForce * Time.fixedDeltaTime);
            _player.transform.position = new Vector3(
          Mathf.Clamp(_player.transform.position.x, borders.Min_X, borders.Max_X),
          _player.transform.position.y,
           Mathf.Clamp(_player.transform.position.z, borders.Min_Z, borders.Max_Z)
          );

        }
    }

}

[System.Serializable]
public class Borders
{
    public float Min_X, Max_X, Min_Z, Max_Z;
}
