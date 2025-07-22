using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource backgroundMusic;

    void Start()
    {
        if (!backgroundMusic.isPlaying)
        {
            backgroundMusic.Play();
            DontDestroyOnLoad(gameObject);
        }
    }
}
