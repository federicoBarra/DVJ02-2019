using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase07
{
public class SOUser : MonoBehaviour
{
    public ScriptableObjectExample data;

    private void Start()
    {
        Debug.Log(data.nombre);
        Debug.Log(data.algunValor);
        if (data.imagen)
            Debug.Log(data.imagen.name);
    }
}
}
