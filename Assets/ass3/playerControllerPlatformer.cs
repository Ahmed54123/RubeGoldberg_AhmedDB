using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControllerPlatformer : MonoBehaviour
{

    public float speed;
    Rigidbody2D myRb;
    public float jumpHeight;
    public float gravMultiply;
    //bool onFloor;
    bool isJumping;

    public SpriteRenderer myRender;
    public Sprite walkSprite;
    public Sprite JumpSprite;


    void Start()
    {
        myRb = gameObject.GetComponent<Rigidbody2D>();
        myRender = gameObject.GetComponent<SpriteRenderer>();

    }

    void Update()
    {

        CheckKeys();
        if(isJumping = false && myRb.velocity.y > 0)
        {
            isJumping = true;
        }

       
    }

    void CheckKeys()
    {
        if (Input.GetKey(KeyCode.D))
        {
            
            HandleLRmovement(speed);
            myRender.flipX = false;
        }

        

        else if(Input.GetKey(KeyCode.A))
        {
            HandleLRmovement(-speed);
            myRender.flipX = true ;
        }


        if (Input.GetKey(KeyCode.W) && isJumping == false)
        {
            myRender.sprite = JumpSprite;
            myRb.velocity = new Vector3(myRb.velocity.x, jumpHeight);
            isJumping = true;
            
            

        }

         if(!Input.GetKey(KeyCode.W) && isJumping == true)
        {
            myRb.velocity += Vector2.up * Physics2D.gravity * (jumpHeight - 1f) * Time.deltaTime;
            
        }
    }

    void HandleLRmovement(float dir)
    {
        myRb.velocity = new Vector3(dir, myRb.velocity.y);
    }

    void JumpPhysics()
    {
        if (myRb.velocity.y < 0)
        {
            myRb.velocity += Vector2.up * Physics2D.gravity.y * (gravMultiply - 1f) * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            myRender.sprite = walkSprite;
            isJumping = false;
        }
    }
}
