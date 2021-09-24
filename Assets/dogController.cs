using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogController : MonoBehaviour
{
    public Transform dogHead;
    Rigidbody2D dogRB;
    public Rigidbody2D studentID;
    void Start()
    {
        dogRB = gameObject.GetComponent<Rigidbody2D>();

        studentID = studentID.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "bucket")
        {
            collision.gameObject.transform.position = dogHead.position;
            dogRB.AddForce(Vector2.right *600f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "pole")
        {
            studentID.gravityScale = 1.5f;
        }
    }
}
