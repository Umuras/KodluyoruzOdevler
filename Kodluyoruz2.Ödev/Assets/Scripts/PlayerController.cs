using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _playerSpeed = 5f;
    private Vector3 scaleChange;
    private Vector3 scaleDecrease;
    private Vector3 scaleZero = new Vector3(0.1f,0.1f,0.1f);
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
        scaleDecrease = new Vector3(0.04f, 0.04f, 0.04f);
    }

    
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 vec = new Vector3(horizontal, 0, 0);
        _rb.velocity = vec * _playerSpeed;
        //transform.localScale -= scaleChange;
        
        
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "food")
        {
            transform.localScale += scaleChange;
        }
        else if(collision.gameObject.tag == "bomb")
        {
            transform.localScale -= scaleChange;
        }
        
    }

    public void ScalePlayer()
    {
        
        transform.localScale += scaleChange;

        if(transform.localScale == scaleZero)
        {
            FindObjectOfType<GameManager>().SetState(StateType.PauseGameState);
        }
    }

    public void ScaleDecrease()
    {
        transform.localScale -= scaleDecrease;
    }
}
