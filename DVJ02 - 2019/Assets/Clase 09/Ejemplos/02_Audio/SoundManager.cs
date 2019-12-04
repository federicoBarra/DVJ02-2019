using UnityEngine;

namespace DVJ02.Clase09
{
public class SoundManager : MonoBehaviour
{
	//test 02
    private AudioSource audioSource;
    private static SoundManager instance;
    [Header("Sound Options")] 
    public bool soundOn = true;
    public bool musicOn = true;

    public enum SoundType
    {
        CommonButton,
        Help,
        Etc
    }

    public enum MusicType
    {
        Ingame,
        MainMenu,
    }

    public AudioClip[] sfxs;
    public AudioClip[] musics;

    public static SoundManager Get()
    {
        return instance;
    }

    // Use this for initialization
    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        instance = this;
        soundOn = PlayerProfile.Get().GetSoundOn();
        musicOn = PlayerProfile.Get().GetMusicOn();
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(SoundType st)
    {
        if (!soundOn)
            return;
        AudioSource.PlayClipAtPoint(sfxs[(int) st], Vector3.zero);
    }

    public void PlayMusic(MusicType mt)
    {
        audioSource.clip = musics[(int) mt];
        if (!musicOn)
            return;

        audioSource.Play();
    }

    public void ToggleSound()
    {
        soundOn = !soundOn;

        if (soundOn)
            PlaySound(SoundType.CommonButton);

        PlayerProfile.Get().SaveSoundOptions(this);
    }

    public void ToggleMusic()
    {
        musicOn = !musicOn;

        if (musicOn)
            audioSource.Play();
        else
            audioSource.Stop();

        PlayerProfile.Get().SaveSoundOptions(this);
    }
}
}