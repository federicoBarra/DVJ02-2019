using UnityEngine;
using UnityEngine.UI;

public class ButtonAddEvents : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button.onClick.AddListener(ButtonClicked);
    }

    public void ButtonClicked()
    {
        Debug.Log("ButtonClickedd");   
    }
}
