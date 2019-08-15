using UnityEngine;
using UnityEngine.UI;

namespace DVJ02.Clase09
{
public class UIOptionsMenu : MonoBehaviour
{
    public Toggle sound;
    public Toggle music;
    public GameObject soundPanel;

    private bool byPassCallbacksToggleSound;
    private bool byPassCallbacksToggleMusic;

    private void Start()
    {
        byPassCallbacksToggleSound = true;
        byPassCallbacksToggleMusic = true;
        sound.isOn = SoundManager.Get().soundOn;
        music.isOn = SoundManager.Get().musicOn;

        byPassCallbacksToggleSound = false;
        byPassCallbacksToggleMusic = false;
    }

    public void SoundToggled()
    {
        if (byPassCallbacksToggleSound)
        {
            byPassCallbacksToggleSound = false;
            return;
        }
        SoundManager.Get().ToggleSound();
    }

    public void MusicToggled()
    {
        if (byPassCallbacksToggleMusic)
        {
            byPassCallbacksToggleMusic = false;
            return;
        }
        SoundManager.Get().ToggleMusic();
    }

    public void TestSound()
    {
        SoundManager.Get().PlaySound(SoundManager.SoundType.CommonButton);
    }

    public void OpenCloseSoundOptions()
    {
        soundPanel.SetActive(!soundPanel.activeInHierarchy);
    }
}
}
