using UnityEngine;
using TMPro;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource backgroundMusic;
    private bool isMuted = false;
    public TMP_Text muteText;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            return;
        }
    }

    void Start()
    {
        if(!backgroundMusic.isPlaying && !isMuted)
        {
            backgroundMusic.Play();
        }
    }

    public void ToggleAudio()
    {
        isMuted = !isMuted;
        backgroundMusic.mute = isMuted;
        UpdateText();
    }

    private void UpdateText()
    {
        if(!isMuted)
        {
            muteText.text = "mute";
        }
        else
        {
            muteText.text = "unmute";
        }
    }
}
