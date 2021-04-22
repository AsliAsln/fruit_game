using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
	PlayerController playerController;
	public List<GameObject> fruits;
	public int combinationNumber;
	private Transform initialSauceObject;
    private Vector3 lastPosition;
    public Transform sauceParents;

	public List<GameObject> panelSigns;
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

    public SignType requiredSignType;


    private void Awake()
    {
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
        
        CreateCombination(10);
        CreatePanelSign(10);


    }
    private void Update()
    {

        if (Grounds[1].transform.position.z < player.transform.position.z)
        {
            ReplaceGrounds();
            CreatePanelSign(1);
            CreateCombination(1);
            CheckSauce();

        }




    }
    private void CreateCombination(int combinationNumber)
	{
        for (int i = 0; i < combinationNumber; i++)
        {
            initialSauceObject = fruits[0].transform;
            lastPosition = initialSauceObject.localPosition;
            int RandomCombination = Random.Range(0, fruits.Count);
            GameObject nextCombination = Instantiate(fruits[RandomCombination], sauceParents);    
            nextCombination.transform.localPosition = lastPosition + new Vector3(0f, 0f, 10f);
            fruits.Add(nextCombination);
            fruits.RemoveAt(0);
        }
  	}



    private void CreatePanelSign(int panelSignNumber)
    {
        for (int i = 0; i < panelSignNumber; i++)
        {
            int RandomSign = Random.Range(0, panelSigns.Count);
            GameObject nextSign = Instantiate(panelSigns[RandomSign], curPos.position + new Vector3(306f, 0f, 0f), Quaternion.identity, Sign.transform);
            curPos = nextSign.transform;
        }
    }


    private void ReplaceGrounds()
    {
        GameObject myTempFirstGrounds = Grounds[0];
        myTempFirstGrounds.transform.position = Grounds[4].transform.position + new Vector3(0f, 0f,40f);
        Grounds.Add(myTempFirstGrounds);
        Grounds.RemoveAt(0);

    }








    private void CheckSauce()
    {
        if ((strawberrySign.transform.position == new Vector3(-9f, -45f, 0f)) && ((player.position.z > strawbery.transform.position.z - 2) && (player.position.z < strawbery.transform.position.z + 2)))
        {

            score += 10;
            Sign.transform.position += new Vector3(-222, 0, 0);
          
        }
        else if ((bananaSign.transform.position == new Vector3(-9f, -45f, 0f)) && ((player.position.z > banana.transform.position.z - 2) && (player.position.z < banana.transform.position.z + 2)))
        {


            score += 10;
            Sign.transform.position += new Vector3(-222, 0, 0);


        }
        else if ((appleSign.transform.position == new Vector3(-9f, -45f, 0f)) && ((player.position.z > apple.transform.position.z - 2) && (player.position.z < apple.transform.position.z + 2)))
        {
            score += 10;
            Sign.transform.position += new Vector3(-222, 0, 0);


        }
        else
        {
            score = 0;
        }
    }

   }








    //void Update()
    //{
    //    float distance = fruits[0].transform.position.x - playerController.transform.position.x;
    //    if (distance > 10)
    //    {
    //        ShuffleFruits(fruits);
    //        instantiateList(fruits);
    //    }
    //    ShuffleFruits(fruits);
    //    instantiateList(fruits);


    //}



    //private static List<GameObject> ShuffleFruits(List<GameObject> aList)
    //{
    //    GameObject myGO;

    //    int n = aList.Count;
    //    for (int i = 0; i < n; i++)
    //    {

    //        int r = Random.Range(i, n); ;
    //        myGO = aList[r];
    //        aList[r] = aList[i];
    //        aList[i] = myGO;
    //    }

    //    return aList;
    //}
    //private static void instantiateList(List<GameObject> aList)
    //{
    //    Instantiate(aList[0], aList[0].transform.position + new Vector3(-4f, 0), Quaternion.identity);
    //    Instantiate(aList[1], aList[1].transform.position + new Vector3(-4f, 0), Quaternion.identity);
    //    Instantiate(aList[2], aList[2].transform.position + new Vector3(-4f, 0), Quaternion.identity);

    //}

    //private void OnTriggerEnter(Collision other)
    //{
    //    if (Collision.gameObject.tag = "")
    //    {

    //    }
    //    {

    //    }
    //}
    
