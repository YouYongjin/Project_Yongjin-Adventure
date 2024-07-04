using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;

    public float moveSpeed;
    public float jumpForce;
    bool isGrounded;
    public int score = 0;
    GameObject scorePoint;

    public LayerMask groundLayer;  // 바닥 레이어를 설정하기 위한 레이어 마스크
    public Transform groundCheck;  // 바닥 체크를 위한 Transform

    Rigidbody2D playerRigid;
    public Vector2 playerVector;
    

    void Awake()
    {
        playerRigid = GetComponent<Rigidbody2D>();
        playerVector = this.gameObject.transform.position;
    }

    void Update()
    {
        PlayerMove();
        MoveSpeedUp();
        MoveStop();

        CheckGrounded();
        if(isGrounded && Input.GetButtonDown("Jump"))Jump();

    }
    void FixedUpdate()
    {
        //RaycastJump();
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

    void CheckGrounded()
    {
        float rayLength = 0.1f;  // 레이 길이
        RaycastHit2D hit = Physics2D.Raycast(groundCheck.position, Vector2.down, rayLength, groundLayer);

        if (hit.collider != null)
        {
            isGrounded = true;
            Debug.Log("Grounded");
        }
        else
        {
            isGrounded = false; 
            Debug.Log("Not Grounded");
        }
    }

    void Jump()
    {
        playerRigid.velocity = new Vector2(playerRigid.velocity.x, jumpForce);
    }

    void OnDrawGizmos()
    {
        if(groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(groundCheck.position, groundCheck.position + Vector3.down * 0.1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 
        if(collision.tag == "Point")
        {
            scorePoint = collision.gameObject;
            Debug.Log(scorePoint.name);
        }

        // 아이템 획득
        Item item = collision.GetComponent<Item>();
        if (item != null)
        {
            item.Collect(this);  // 아이템을 획득합니다.
            Debug.Log($"Total Score: {score}");
        }
    }
}
