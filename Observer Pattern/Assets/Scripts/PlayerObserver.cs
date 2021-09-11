using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerObserver : MonoBehaviour
{
    public static event Action onTurnRed;

    void Update()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onTurnRed?.Invoke();
        }
    }
}
