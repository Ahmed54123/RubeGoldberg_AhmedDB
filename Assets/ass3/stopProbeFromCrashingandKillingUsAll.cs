using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopProbeFromCrashingandKillingUsAll : MonoBehaviour
{

    public Rigidbody2D football;
    public GameObject explosionParticle;
    
    void Start()
    {
        football = football.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "changeCam")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.1f;
            collision.gameObject.GetComponent<Rigidbody2D>().mass = 15;

            Instantiate(explosionParticle,collision.gameObject.transform.position, Quaternion.identity);


            football.AddForce(Vector2.right *400);
        }
    }
}
