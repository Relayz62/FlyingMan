using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{
    [SerializeField] private PlayerDeath _playerDeath;

    public delegate void onMoneyPicked<Money>();
    public event onMoneyPicked<Money> moneyPickedEvent;

    public UnityAction OnPickedPower;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Obstacle"))
        {
            _playerDeath.PlayerDead();
        }
        if (collider.CompareTag("Coin"))
        {
            Destroy(collider.gameObject, 0.1f);
            moneyPickedEvent?.Invoke();
        }

        if(collider.CompareTag("PowerPlumage"))
        {
            Destroy(collider.gameObject, 0.1f);
            OnPickedPower?.Invoke();
        }
    }
}

