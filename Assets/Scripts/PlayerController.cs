using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float moveSpeed;
    public Vector3 force;
    public Animator playerAnimator;
    private Vector2 Direction;
    
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);



        if (Input.GetKeyDown(KeyCode.D))
        {
            playerAnimator.SetBool("isJumping", true);
            playerAnimator.Play("Jump");
            rb.AddForce(force);
            AudioManager.Instance.PlaySound(SoundTypes.Jump);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            playerAnimator.SetBool("isJumping", true);
            playerAnimator.Play("Jump");
            rb.AddForce(-force);
            AudioManager.Instance.PlaySound(SoundTypes.Jump);
        }
        else
        {
            playerAnimator.SetBool("isJumping", false);

        }

    }

}