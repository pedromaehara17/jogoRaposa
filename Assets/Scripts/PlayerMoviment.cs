using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class PlayerMoviment : MonoBehaviour
{


    public CharacterController2D controller;

    public Animator animator;


    float horizontalMove = 0f;

    float runSpeed = 50f;

    bool jump = false;

    bool crouch = false;


    // Update is called once per frame

    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;


        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));


        if (Input.GetButtonDown("Jump"))
        {

            jump = true;

            //animator.SetBool("IsJumping", true);

        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("para baixo");
            crouch = true;

        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("para cima");
            crouch = false;

        }

    }


    public void OnLanding()
    {

        //animator.SetBool("IsJumping", false);

    }


    void FixedUpdate()
    {

        // move our character

        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);

        jump = false;



    }

    


}