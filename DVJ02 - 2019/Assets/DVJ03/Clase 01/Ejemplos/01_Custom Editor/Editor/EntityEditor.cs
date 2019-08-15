using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace DVJ03.Clase01
{
[CustomEditor(typeof(EntityExample))]
public class EntityEditor : Editor
{
    SerializedProperty sp_unInt;
    SerializedProperty sp_texto;
    SerializedProperty sp_unBool;
    SerializedProperty sp_cosas;
    public override void OnInspectorGUI()
    {
        EntityExample e = (EntityExample)target;
        GUILayout.Space(5f);
        EditorGUILayout.LabelField("Configuracion del objeto");

        serializedObject.Update();

        EditorGUILayout.PropertyField(sp_cosas);
        EditorGUILayout.PropertyField(sp_unInt);
        if (e.unInt <= 0)
            EditorGUILayout.PropertyField(sp_texto);
        else
            EditorGUILayout.PropertyField(sp_unBool);

        serializedObject.ApplyModifiedProperties();

    }

    void OnEnable()
    {
        sp_unInt = serializedObject.FindProperty("unInt");
        sp_texto = serializedObject.FindProperty("texto");
        sp_unBool = serializedObject.FindProperty("unBool");
        sp_cosas = serializedObject.FindProperty("cosas");
    }


}
}
