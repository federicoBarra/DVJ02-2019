using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace DVJ03.Clase01
{
    public class EditorOptions : Editor
    {
        [MenuItem("DVJ03/Clase01", false, 10)]
        private static void ShowTextInConsole()
        {
            Debug.Log("ShowTextInConsole");
        }

        [MenuItem("GameObject/DVJ03/Create Item", false, 10)]
        private static void CreateItem()
        {
            GameObject go = new GameObject("Nuevo GameObject");
            go.AddComponent<Rigidbody>();
        }
    }
}