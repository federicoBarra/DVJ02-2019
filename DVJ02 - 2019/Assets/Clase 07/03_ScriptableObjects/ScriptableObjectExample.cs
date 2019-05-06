using UnityEngine;

namespace DVJ02.Clase07
{
[CreateAssetMenu(fileName = "ScriptableObjectExample", menuName = "Clase DVJ02/ScriptableObjectExample" + "", order = 1)]
public class ScriptableObjectExample : ScriptableObject
{
    //https://docs.unity3d.com/Manual/class-ScriptableObject.html
    public string nombre;
    public float algunValor;
    public Sprite imagen;

    public string GetBasicInfo()
    {
        return nombre + " | " + algunValor;
    }
}
}

