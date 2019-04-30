using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase06
{
public class DelegateBasis : MonoBehaviour
{
    //Un delegate es basicamente un puntero a funcion.
    public delegate void PunteroAFuncion(string s); //define el signature del delegate (delegate type)
    
    private void Start()
    {
        PunteroAFuncion punteroALog; //(delegate instance)

        punteroALog = Debug.Log;

        punteroALog("Mostrando puntero a funcion Debug.Log() ");

        punteroALog = PrintPropio;

        punteroALog("Mostrando puntero a PrintPropio() ");
    }

    void PrintPropio(string s)
    {
        Debug.Log(s + "\n");
    }
}
}
