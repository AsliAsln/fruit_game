using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    PlayerController playerController;
    public TopBarController topBar;
 


    public List<GameObject> fruits;
    public List<GameObject> panelSigns;


    public int combinationNumber;
    private Transform initialSauceObject;
    private Vector3 lastPosition;
    public Transform sauceParents;
    public Transform curPos;
    public GameObject Sign;



    public Transform player;


    public GameObject apple;
    public GameObject banana;
    public GameObject strawbery;

    public int score;

    public List<GameObject> Grounds;
    public GameObject strawberrySign;
    public GameObject bananaSign;
    public GameObject appleSign;

    public SauceType requiredSignType;






    private void Awake()
    {
                initialSauceObject = fruits[0].transform;

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

        CreatePanelSign(15);
        CreateCombination(15);

    }
    private void Update()
    {

        if (Grounds[1].transform.position.z < player.transform.position.z)
        {

            CreatePanelSign(4);
            CreateCombination(4);
            ReplaceGrounds();
        }
        




    }
    private void CreateCombination(int combinationNumber)
    {

        for (int i = 0; i < combinationNumber; i++)
        {
            lastPosition = initialSauceObject.localPosition;
            int RandomCombination = Random.Range(0, fruits.Count);
            GameObject nextCombination = Instantiate(fruits[RandomCombination], sauceParents);
            nextCombination.transform.localPosition = lastPosition + new Vector3(0f, 0f, 10f);
            initialSauceObject = nextCombination.transform;
        }
    }
   



    private void CreatePanelSign(int panelSignNumber)
    {
        for (int i = 0; i < panelSignNumber; i++)
        {
            int RandomSign = Random.Range(0, panelSigns.Count);
            GameObject nextSign = Instantiate(panelSigns[RandomSign], curPos.position + new Vector3(206f, 0f, 0f), Quaternion.identity, Sign.transform);
            curPos = nextSign.transform;

        }
    }


    private void ReplaceGrounds()
    {
        GameObject myTempFirstGrounds = Grounds[0];
        myTempFirstGrounds.transform.position = Grounds[4].transform.position + new Vector3(0f, 0f, 40f);
        Grounds.Add(myTempFirstGrounds);
        Grounds.RemoveAt(0);

    }

   private void checkSace()
    {
        
    }

}

