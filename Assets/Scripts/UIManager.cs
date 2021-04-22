using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour


    


{

    private void Awake()
    {
        AudioManager.Instance.PlayBgMusic(BgMusicTypes.bgMusic);

    }





    // Start is called before the first frame update
    public void PlayGame()
    {
        AudioManager.Instance.PlaySound(SoundTypes.Button);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SoundButtoPressed()
    {

        AudioManager.Instance.PlaySound(SoundTypes.Button);
    }



}
