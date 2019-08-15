using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace DVJ03.Clase01
{
    public class WindowExample : EditorWindow
    {
        private const string TexturesPath = "Assets/DVJ03/Clase 01/Textures/";
        private static Texture2D dummyTexture;
        private Rect graphRect = new Rect(new Vector2(50, 50), new Vector2(500, 250));


        [MenuItem("Window/DVJ03/Mi Ventana")]
        private static void InitWindow()
        {
            var w = EditorWindow.CreateInstance<WindowExample>();
            w.titleContent = new GUIContent("Mi Ventana");
            w.Show();
        }

        private void OnGUI()
        {
            EditorGUILayout.BeginVertical();
            GUILayout.Label("Hola, soy una ventana");
            if (GUILayout.Button("Load Texture"))
            {
                Texture2D tex = AssetDatabase.LoadAssetAtPath<Texture2D>(TexturesPath + "tex01.png");
                if (tex != null)
                {
                    dummyTexture = tex;
                }
            }
            if (dummyTexture != null)
            {
                GUI.DrawTexture(graphRect, dummyTexture);
            }
            EditorGUILayout.BeginVertical();
        }

    }
}
