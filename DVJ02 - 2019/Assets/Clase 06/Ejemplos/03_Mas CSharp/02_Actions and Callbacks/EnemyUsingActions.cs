using System;
using UnityEngine;

namespace DVJ02.Clase06
{
public class EnemyUsingActions : MonoBehaviour
{
    //definicion básica de un Action
    //public delegate void Action<T>(T param);
    //Un Action es un delegate ya predefinido usando Generics.
    private Action<EnemyUsingActions> callbackOnDeath;

    private void OnMouseDown()
    {
        EnemyDied();
    }

    void EnemyDied()
    {
        DieAsACallback();
    }

    public void SetCallback(Action<EnemyUsingActions> callback)
    {
        callbackOnDeath = callback;
        //podría ser tambien
        //callbackOnDeath += callback;
    }

    private void DieAsACallback()
    {
        if (callbackOnDeath != null)
            callbackOnDeath(this);
    }
}
}
