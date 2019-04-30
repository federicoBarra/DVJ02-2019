using System;
using UnityEngine;

namespace DVJ02.Clase06
{
public class CSAnonymMethods : MonoBehaviour
{
    public Action variasAcciones;
    public Action metodoAnonimo;

    private void Start()
    {
        //TODO XXX esto es un ejemplo de lo que no quiero ver en el código de los tps o parciales.

        metodoAnonimo = delegate { Debug.Log("Metodo Anónimo"); };

        variasAcciones += metodoAnonimo;

        //XXX Estoy pisando la funcion anterior.
        metodoAnonimo = () => { Debug.Log("Metodo Anónimo 02"); }; 

        variasAcciones += metodoAnonimo;

        if (variasAcciones != null)
            variasAcciones();


        Action<int> sendToLog = (param) => { Debug.Log("param: " + param); };
        //Es lo mismo que
        //UnityAction<int> sendToLog = delegate(int param) { Debug.Log("param: " + param); };

        sendToLog(5);
    }
}
}