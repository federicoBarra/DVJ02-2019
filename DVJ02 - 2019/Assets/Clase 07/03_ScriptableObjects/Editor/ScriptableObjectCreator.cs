using UnityEditor;

namespace DVJ02.Clase07
{
    public class ScriptableObjectCreator : Editor
    {
        private const string Path = "Assets/Clase 06/Ejemplos";

        [MenuItem("DVJ02/Crear Scriptable Object")]
        private static void CreateScriptableObjectExample()
        {
            ScriptableObjectExample asset = CreateInstance<ScriptableObjectExample>();
            asset.name = "New SO " + asset.GetInstanceID();
            asset.name = asset.name.Replace("-", "");
            AssetDatabase.CreateAsset(asset, Path + "/" + asset.name + ".asset");

            AssetDatabase.SaveAssets();
            EditorUtility.SetDirty(asset);

        }
    }
}
