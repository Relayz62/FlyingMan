using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{

    public Transform MoneyObject;

    private void FixedUpdate()
    {
        RotateMoney();
    }

    private void RotateMoney()
    {
        MoneyObject.transform.Rotate(new Vector3(20, 30, 30) * Time.fixedDeltaTime);
    }
}
