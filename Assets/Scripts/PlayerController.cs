using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float moveSpeed;
    public Vector3 force;
    public Animator playerAnimator;
    public Transform right;
    public Transform left;
    public Transform middle;
    private bool rightSwipe;
    private bool leftSwipe;



    // Start is called before the first frame update
    private void Start()
    {

        rb = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(rightSwipe);
        //Debug.Log(leftSwipe);

        leftSwipe = GameManager.Instance.swipeControler.leftDirection;

        rightSwipe = GameManager.Instance.swipeControler.rightDirection;

        transform.Translate(Vector3.forward * Time.deltaTime * speed);



        if (rightSwipe)
        {
            playerAnimator.SetBool("isJumping", true);
            playerAnimator.Play("Jump");

            if (transform.position.x == left.localPosition.x)
            {
                Debug.Log("i am going middle");
                middleMove();
            }

            else if (transform.position.x == middle.localPosition.x)
            {
                rightMove();
                Debug.Log("i am goinh right");
            }

            AudioManager.Instance.PlaySound(SoundTypes.Jump);
        }

        else if (leftSwipe)
        {
            playerAnimator.SetBool("isJumping", true);
            playerAnimator.Play("Jump");

            if (transform.position.x == right.localPosition.x)
            {
                middleMove();
            }

            else if(transform.position.x == middle.localPosition.x)

                leftMove();

            AudioManager.Instance.PlaySound(SoundTypes.Jump);
        }
        else
        {
            playerAnimator.SetBool("isJumping", false);

        }


        void leftMove()
        {
            transform.DOMoveX(left.localPosition.x, 0.5f);
        }
        void rightMove()
        {
            transform.DOMoveX(right.localPosition.x, 0.5f);
        }
        void middleMove()
        {
            
              transform.DOMoveX(middle.localPosition.x, 0.5f);

           
        }
        

    }
    public void GameEnded()
    {
        rb.velocity = new Vector3(0f, 0f, 0f);
    }
}
