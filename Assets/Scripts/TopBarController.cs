using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBarController : MonoBehaviour
{
    public RectTransform RectTransform;
    public Transform curPos;
    public List<GameObject> panelSigns;
    public List<GameObject> signs;

    public GameObject Sign;



    int signTypeNumber;
    // Start is called before the first frame update
    private void Start()
    {



        CreatePanelSign(15);
        RectTransform = GetComponent<RectTransform>();
        SetRequiredFruit();
       

    }
  
   
    // Update is called once per frame
    public void SetRequiredFruit()
    {
        GameManager.Instance.requiredSignType = signs[0].GetComponent<Sauces>().curSignType;
        //Debug.Log("set  required fruit to:" + signs[0].GetComponent<Sauces>().curSignType);
    }
    public void ChangeRequiredFruit()
    {
        CreatePanelSign(1);
        //rectTransfor.sizeDelta
        //Destroy(signs[0]);
        signs.RemoveAt(0);
        SetRequiredFruit();
        //Debug.Log("Required sauce type change to:  " + GameManager.Instance.requiredSignType);
    }
    private void CreatePanelSign(int panelSignNumber)
    {
        
        for (int i = 0; i < panelSignNumber; i++)
        {

            int RandomSign = Random.Range(0, panelSigns.Count);
            GameObject nextSign = Instantiate(panelSigns[RandomSign], curPos.position + new Vector3(206f, 0f, 0f), Quaternion.identity,Sign.transform);
            curPos = nextSign.transform;
            signs.Add(nextSign);


        }
    }


}
