using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeScript : MonoBehaviour
{

    public GameObject particleExplode;
    public ParticleSystem explosion;
    public GameObject studentID;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(particleExplode, gameObject.transform.position, Quaternion.identity);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "pole")
        {
            studentID.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
