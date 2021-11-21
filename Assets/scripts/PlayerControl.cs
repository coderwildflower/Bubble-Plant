using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControl : MonoBehaviour
{
   
    private float moveSpeedX = 5;
    private float moveSpeedY = 10;
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
    public float MoveSpeedY
    {
        get
        {
            return moveSpeedY;
        }
        set
        {
            moveSpeedY = value;
        }
    }

    Rigidbody2D playerRb;    
    // Start is called before the first frame update
    void Awake()
    {
       
    }

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float xPos = Input.GetAxis("Horizontal") * moveSpeedX * Time.deltaTime;

        transform.position += new Vector3(xPos, 0);
    }

    void PlayerJump()
    {

    }
}
