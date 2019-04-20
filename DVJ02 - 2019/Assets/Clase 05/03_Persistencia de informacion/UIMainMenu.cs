using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DVJ02.Clase05
{
public class UIMainMenu : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Get().StartGame();
    }
}
}
