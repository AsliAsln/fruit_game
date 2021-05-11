using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static SauceController sauceController;
    public PlayerController playerController;
    public SwipeControls swipeControler;
    public TopBarController topBar;
    public Transform firsCombination;


    public List<GameObject> fruits;




    public int combinationNumber;
    private Transform initialSauceObject;
    private Vector3 lastPosition;
    public Transform sauceParents;

    public bool isGameStarted = false;



    public Transform player;


    public GameObject apple;
    public GameObject banana;
    public GameObject strawbery;

    public int score;
    public int highScore;
    private int bestScoreNum;


    public List<GameObject> Grounds;
    public GameObject strawberrySign;
    public GameObject bananaSign;
    public GameObject appleSign;

    public SauceType requiredSignType;
    public UIManager uiManager;





    private void Awake()
    {

       initialSauceObject = firsCombination;

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }



    private void Start()
    {
        uiManager.gameOverPanel.SetActive(false);


        highScore=PlayerPrefs.GetInt("HighScore");
        CreateCombination(15);

    }
    private void Update()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }



        if (Grounds[1].transform.position.z < player.transform.position.z)
        {
      
            CreateCombination(4);
            ReplaceGrounds();
        }
        




    }
    private void CreateCombination(int combinationNumber)
    {

        for (int i = 0; i < combinationNumber; i++)
        {
            lastPosition = initialSauceObject.localPosition;
            int randomCombination = Random.Range(0, fruits.Count);
            

            GameObject nextCombination = Instantiate(fruits[randomCombination], sauceParents);
            nextCombination.transform.localPosition = lastPosition + new Vector3(0f, 0f, 15f);
            initialSauceObject = nextCombination.transform;
        }
    }
   



   


    private void ReplaceGrounds()
    {
        GameObject myTempFirstGrounds = Grounds[0];
        myTempFirstGrounds.transform.position = Grounds[4].transform.position + new Vector3(0f, 0f, 40f);
        Grounds.Add(myTempFirstGrounds);
        Grounds.RemoveAt(0);

    }

  

   
    
    void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }


}

