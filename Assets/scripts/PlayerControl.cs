using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float moveSpeedX = 5;

    [SerializeField]
    private float jumpSpeed = 5;
    public float MoveSpeed
    {
        get
        {
            return moveSpeedX;
        }
        set
        {
            moveSpeedX = value;
        }
    }
    public float JumpSpeed
    {
        get
        {
            return jumpSpeed;
        }
        set
        {
            jumpSpeed = value;
        }
    }

    Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerJump();
    }

    void PlayerMove()
    {
        float xPos = Input.GetAxis("Horizontal");

        if (xPos < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (xPos > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        transform.position += new Vector3(xPos, 0) * moveSpeedX * Time.deltaTime;
    }

    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.velocity = new Vector2(0, jumpSpeed);
        }
    }
}
