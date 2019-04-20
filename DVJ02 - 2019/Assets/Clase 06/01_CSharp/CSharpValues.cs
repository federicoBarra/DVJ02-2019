using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase04
{
public class CSharpValues : MonoBehaviour
{
    //reference type
    public class TuplaClass
    {
        public int x;
        public int y;

        public void ShowInConsole()
        {
            Debug.Log("(" + x + ", " + y + ")");
        }
    }

    //value type
    public struct TuplaStruct
    {
        public int x;
        public int y;

        public void ShowInConsole()
        {
            Debug.Log("(" + x + ", " + y + ")");
        }
    }

    // Use this for initialization
    private void Start()
    {
        Debug.Log("Class");
        ClassShow();
        Debug.Log("Struct");
        StructShow();

        string pepe = "pepe";

        ModifyString(pepe);
        Debug.Log(pepe);

        ModifyStringByReference(ref pepe);
        Debug.Log(pepe);
    }

    private void ClassShow()
    {
        TuplaClass tupla01 = new TuplaClass();
        tupla01.x = 10;
        tupla01.y = 10;

        TuplaClass tupla02 = new TuplaClass();
        tupla02.x = 20;
        tupla02.y = 20;

        TuplaClass tupla03 = tupla01;

        tupla03.x = 30;

        tupla03.ShowInConsole();
        tupla01.ShowInConsole();

        tupla03 = tupla02;

        tupla03.ShowInConsole();

        tupla01 = tupla02;

        tupla01.ShowInConsole();
    }

    private void StructShow()
    {
        TuplaStruct tupla01 = new TuplaStruct();
        tupla01.x = 10;
        tupla01.y = 10;

        TuplaStruct tupla02 = new TuplaStruct();
        tupla02.x = 20;
        tupla02.y = 20;

        TuplaStruct tupla03 = tupla01;

        tupla03.x = 30;

        tupla03.ShowInConsole();
        tupla01.ShowInConsole();

        tupla03 = tupla02;

        tupla03.ShowInConsole();

        tupla01 = tupla02;

        tupla01.ShowInConsole();
    }

    private void ModifyString(string s)
    {
        s = "tito";
    }

    private void ModifyStringByReference(ref string s)
    {
        s = "tito";
    }
}
}
