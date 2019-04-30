using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase06
{
public class CSGenerics : MonoBehaviour
{

    // Use this for initialization
    private void Start()
    {
        GenericMethod<int>(0);
        GenericMethod<string>("string");

        SomeManager.Get().SomeMethod();
    }

    // Update is called once per frame
    private void Update()
    {

    }

    private void GenericMethod<T>(T index)
    {
        T something = index;
        Debug.Log(something);
    }

}
}