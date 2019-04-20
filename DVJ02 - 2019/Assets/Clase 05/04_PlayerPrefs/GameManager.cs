using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DVJ02.Clase05
{
public class GameManager : MonoBehaviour
{
    public int Score = 10;

    private static GameManager instance;
    public static GameManager Get()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("GameManager already created, thera can be only one. Destroing this reference.");
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        instance = this;
    }

    public void StartGame()
    {
        Score = 0;
        SceneManager.LoadScene("DontDestroy 02 Game");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("DontDestroy 03 End");
    }


    public void Load()
    {
        Persistance.Get().LoadGame(this);
    }

    public void Save()
    {
        Persistance.Get().SaveGame(this);
    }

}

}