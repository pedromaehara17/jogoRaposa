using UnityEngine;

using System.Collections;


public class PlayerController: MonoBehaviour {

        public Animator Anime;

        public Rigidbody2D playerRigidbody;

        public int forceJump;


public bool slide;

        

        public Transform GroundCheck;

        public bool grounded;

        public LayerMask whatIsGround;


        public float slideTemp;

        public float timeTemp;


        void Start () {

        

        }


        void Update () {

                

                if(Input.GetButtonDown("Jump") && grounded == true){

                        playerRigidbody.AddForce(new Vector2(0, forceJump));

                        slide = false;

                }


                if(Input.GetButtonDown("Slide") && grounded == true){

                        slide = true;

                        timeTemp = 0;

                }


                grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, whatIsGround);


                if(slide == true){

                        timeTemp += Time.deltaTime;

                        if(timeTemp >= slideTemp){

                                slide = false;

                        }

                }


                Anime.SetBool("jump", !grounded);

        }
       }