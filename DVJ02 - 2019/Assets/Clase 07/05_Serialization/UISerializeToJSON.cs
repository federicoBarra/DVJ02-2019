using UnityEngine;

namespace DVJ02.Clase06
{
public class UISerializeToJSON : MonoBehaviour
{
    public PlayerData playerData;

    public string serializedData = "";

    public void SerializePlayer()
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/
        serializedData = JsonUtility.ToJson(playerData);
        //https://jsonformatter.curiousconcept.com/
    }
    public void DeserializePlayer()
    {
        playerData = JsonUtility.FromJson<PlayerData>(serializedData);
    }
}
}
