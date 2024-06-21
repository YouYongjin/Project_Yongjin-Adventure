using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    Rigidbody2D playerRigid;
    bool jumpCheck = false;

    void Awake()
    {
        playerRigid = GetComponent<Rigidbody2D>();        
    }

    void Update()
    {
        PlayerMove();
        MoveSpeedUp();
        MoveStop();
        if(jumpCheck)PlayerJump();
    }    

    void PlayerMove()
    {
        float h = Input.GetAxisRaw("Horizontal");
        playerRigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (playerRigid.velocity.x > moveSpeed)
        {
            playerRigid.velocity = new Vector2(moveSpeed, playerRigid.velocity.y);
        }
        else if (playerRigid.velocity.x < moveSpeed * (-1))
        {
            playerRigid.velocity = new Vector2(moveSpeed * (-1), playerRigid.velocity.y);
        }
    }

    void MoveSpeedUp()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed + 5f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed - 5f;
        }
    }
    void MoveStop()
    {
        if (Input.GetButtonUp("Horizontal"))
        {
            playerRigid.velocity = new Vector2(playerRigid.velocity.normalized.x * 0.5f, playerRigid.velocity.y);
        }
    }

    void PlayerJump()
    {
        //if(jumpCheck == true)
        //{
            if(Input.GetButtonDown("Jump"))
            {
                playerRigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Ground"))
        {
            jumpCheck = true;
            Debug.Log("점프 가능");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Ground"))
        {
            jumpCheck = false;
            Debug.Log("점프 불가능");
        }
    }
}
