using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour

{
    public GameObject gameOverPanel;
    public GameObject pausePanel;

    public Text score;
    public TextMeshProUGUI lastScore;
    public TextMeshProUGUI bestScore;
    private void Awake()
    {   
        AudioManager.Instance.PlayBgMusic(BgMusicTypes.bgMusic);

    }
    private void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
    }

    void Update()
    {
        if (score != null)
        {
            score.text = GameManager.Instance.score.ToString();
        }
        if (lastScore != null)
        {
            lastScore.text = "SCORE: "+GameManager.Instance.score.ToString();
        }
        if (bestScore != null)
        {
            bestScore.text = "High Score: " + GameManager.Instance.highScore;
        }
    }



    // Start is called before the first frame update
    public void PlayGame()
    {
        AudioManager.Instance.PlaySound(SoundTypes.Button);
        SceneManager.LoadScene(1);
        gameOverPanel.SetActive(false);
    }

    public void SoundButtoPressed()
    {

        AudioManager.Instance.PlaySound(SoundTypes.Button);
    }

    

    public void GameOver()
    {
        gameOverPanel.SetActive(true);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);


    }
    public void pauseMenu()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;

    }
    public void resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;

    }









}
