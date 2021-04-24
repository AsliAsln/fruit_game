using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBarController : MonoBehaviour
{
    int signTypeNumber;
    // Start is called before the first frame update
    void update()
    {
        ChangeRequiredFruit();
    }
   
    // Update is called once per frame
    public void ChangeRequiredFruit()
    {
        if (GameManager.Instance.appleSign.transform.position.x == -9)
        {
            GameManager.Instance.requiredSignType = SauceType.apple;
        }
        else if (GameManager.Instance.strawberrySign.transform.position.x == -9)
        {
            GameManager.Instance.requiredSignType = SauceType.strawberry;
        }
        else if (GameManager.Instance.bananaSign.transform.position.x == -9)
        {
            GameManager.Instance.requiredSignType = SauceType.banana;
        }
    }
   

}
