using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    // Use this for initialization

    public int health = 100;
    public List<float> volumes;
    private Scene scene;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    public bool death = false;
    public bool isGameOver = false;
    bool jump = false;
    public static float scoreGim = 0;
    public CharacterController2D controller;
    public GameObject diagcanvas;
    void Start()
    {
        scene = SceneManager.GetActiveScene();

    }
    // Update is called once per frame
    void Update()
    {
       if (!death)
         {

            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("speed", Mathf.Abs(horizontalMove));
            // float verticalMove = joystick.Vertical;

            if (Input.GetKey(KeyCode.Space))
     {
                 jump = true;
               animator.SetBool("isJumping", jump);
            }
            else
            {
                jump = false;
                animator.SetBool("isJumping", jump);
            }



      }
         else
   {
       Debug.Log("You are dead");

 }
    
    }

    void FixedUpdate()
    {
        // Move our character

      
        controller.Move(horizontalMove * Time.fixedDeltaTime , false , jump);
        jump = false;
        animator.SetBool("isJumping", jump);
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "death")
        {

            Death(); //restart game 
        }
        if (col.tag == "directions")
        {
            diagcanvas.SetActive(true);
            Debug.Log("back this way player move foward and then jump");
            diagcanvas.SetActive(false);
        }
        else
        {
            diagcanvas.SetActive(false);
        }
        if (col.tag == "final")
        {
            Debug.Log("final door");
            SceneManager.LoadScene(scene.buildIndex+1);
        }
    }

    public void Death()
    {
        animator.SetBool("isDead", true);
        Debug.Log("you died ");
        SceneManager.LoadScene(scene.buildIndex);
    }

    }
