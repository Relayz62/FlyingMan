using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _playerAnimator;

    public void SetAnimationBool(string name, bool value)
    {
        _playerAnimator.SetBool(name, value);
    }
}
