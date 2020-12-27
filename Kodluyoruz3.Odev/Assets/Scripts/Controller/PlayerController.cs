using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _rb;
    Animator animator;
    private float _speed = 10.0f;
    Vector3 moveDir = Vector3.zero;
    float rot = 0f;
    float rotSpeed = 150f;
    CharacterController character;
    private float gravityScale = 9.8f;
    void Start()
    {

        animator = GetComponent<Animator>();
        character = GetComponent<CharacterController>();
    }


    void Update()
    {
        
        PlayerMove();
    }


    public void PlayerMove()
    {


        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isRunning", true);
            moveDir = new Vector3(0, 0, 1);
            moveDir *= _speed;
            moveDir = transform.TransformDirection(moveDir);


        }

        else if (Input.GetKeyUp(KeyCode.W))
        {
            moveDir = new Vector3(0, 0, 0);
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isRunning", true);
            moveDir = new Vector3(0, 0, -1);
            moveDir *= _speed;
            moveDir = transform.TransformDirection(moveDir);


        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            moveDir = new Vector3(0, 0, 0);
            animator.SetBool("isRunning", false);
        }




        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDir.y -= gravityScale * Time.deltaTime;

        character.Move(moveDir * Time.deltaTime);

    }



}
