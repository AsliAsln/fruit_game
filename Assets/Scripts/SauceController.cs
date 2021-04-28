using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceController : MonoBehaviour
{
    private ParticleSystem particle;
    public SauceType sauceType;
    // Start is called before the first frame update
    private void Start()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        particle.gameObject.SetActive(false);
        

    }



    // Update is called once per frame

    private void OnTriggerEnter(Collider other)

    {
        
        if (other.gameObject.tag == "player")
        {
            particle.gameObject.SetActive(true);

            Debug.Log(GameManager.Instance.requiredSignType);

            particle.gameObject.SetActive(true);

            if (GameManager.Instance.requiredSignType == sauceType)
            {

                GameManager.Instance.score += 10;
                GameManager.Instance.topBar.ChangeRequiredFruit();
                GameManager.Instance.topBar.ChangeRequiredFruit();
                GameManager.Instance.Sign.transform.localPosition+=new Vector3(-206,0,0);
            }
            else
            {
                Debug.Log(sauceType);
                GameManager.Instance.score -= 10;
                GameManager.Instance.topBar.ChangeRequiredFruit();

            }

        }
        else
        {
            particle.gameObject.SetActive(false);

        }

    }
}
