using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0f;
        jumpForce = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerMove()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {

        }
    }
}
