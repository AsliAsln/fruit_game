using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BgMusicTypes { bgMusic }
public enum SoundTypes { Jump,Button };



public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource bgMusic;
    public AudioSource jumpSound;
    public AudioSource buttonSound;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBgMusic(BgMusicTypes currMusic)
    {
        if (PlayerPrefs.GetInt("IsMuted") == 1)
        {
            return;
        }

        switch (currMusic)
        {
            case BgMusicTypes.bgMusic:
                bgMusic.volume = 0.1f;
                bgMusic.Play();
                break;
        }
    }

    public void PlaySound(SoundTypes currentSound)
    {
        if (PlayerPrefs.GetInt("IsMuted") == 1)
        {
            return;
        }

        switch (currentSound)
        {
            case SoundTypes.Jump:
                jumpSound.Play();
                break;
                  
            case SoundTypes.Button:
                buttonSound.Play();
                break;
        }
    }

    public void MuteStateChanged()
    {
        if (PlayerPrefs.GetInt("IsMuted") == 0)
        {
            bgMusic.Play();
        }
        else
        {
            bgMusic.Stop();
        }
    }






}
