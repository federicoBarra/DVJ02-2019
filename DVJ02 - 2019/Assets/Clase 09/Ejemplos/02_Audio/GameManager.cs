using UnityEngine;

namespace DVJ02.Clase09
{
public class GameManager : MonoBehaviour
{

    // Use this for initialization
    private void Start()
    {
        SoundManager.Get().PlayMusic(SoundManager.MusicType.Ingame);
    }
}
}