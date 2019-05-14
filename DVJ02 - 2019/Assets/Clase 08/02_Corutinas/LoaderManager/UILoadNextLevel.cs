using UnityEngine;

namespace DVJ02.Clase08
{
public class UILoadNextLevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        LoaderManager.Get().LoadScene("Loader 02");
        UILoadingScreen.Get().SetVisible(true);
    }

}
}