using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceController : MonoBehaviour
{
    private ParticleSystem particle;
    public SauceType sauceType;
    private bool isPlayerContact = false;

    // Start is called before the first frame update
    private void Start()
    {
            particle = GetComponentInChildren<ParticleSystem>();
        if(particle!=null)
            particle.gameObject.SetActive(false);
        
        
    }



    // Update is called once per frame

    private void OnTriggerEnter(Collider other)

    {
        if ((other.gameObject.tag == "player") && particle != null && !isPlayerContact)
        {
            isPlayerContact = true;
            particle.gameObject.SetActive(true);
            //Debug.Log("Current Sauce Type: " + sauceType + " Required Sauce: " + GameManager.Instance.requiredSignType);
            particle.gameObject.SetActive(true);

            if (GameManager.Instance.requiredSignType == sauceType)
            {
                GameManager.Instance.topBar.ChangeRequiredFruit();
                GameManager.Instance.topBar.RectTransform.anchoredPosition += new Vector2(-206, 0);

                GameManager.Instance.score += 10;

                if (GameManager.Instance.uiManager.score != null)
                {
                    GameManager.Instance.uiManager.score.text = GameManager.Instance.score.ToString();
                }
            }
            else
            {
                if (GameManager.Instance.score > GameManager.Instance.highScore)
                {
                    GameManager.Instance.highScore = GameManager.Instance.score;

                }
                GameManager.Instance.uiManager.GameOver();
                
                
                GameManager.Instance.playerController.speed = 0;



            }

        }
        else
        {
            if(particle)
            particle.gameObject.SetActive(false);
            

        }

    }
}
