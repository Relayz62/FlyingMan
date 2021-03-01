using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powers : MonoBehaviour
{
    [SerializeField] private PlayerTouchControl _playerControl;
    [SerializeField] private TriggerEnter _triggerEnter;
    [SerializeField] private Text _warningText;

    private void OnEnable()
    {
        _triggerEnter.OnPickedPower += StartSlowFly;
    }
    private void OnDisable()
    {
        _triggerEnter.OnPickedPower -= StartSlowFly;
    }

    private void StartSlowFly()
    {
        StartCoroutine(nameof(SlowFly));
    }

    private IEnumerator SlowFly()
    {
        _warningText.enabled = true;
        _playerControl.fallForce = 3f;
        yield return new WaitForSecondsRealtime(10f);
        _playerControl.fallForce = 10f;
        _warningText.enabled = false;
    }
}
