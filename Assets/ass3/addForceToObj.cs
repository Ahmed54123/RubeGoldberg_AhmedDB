using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForceToObj : MonoBehaviour
{

    public Rigidbody2D forcedObj;
    public float power;
    public Vector2 direction;
    public float gravScale;
    

    void Start()
    {
        forcedObj.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        forcedObj.AddForce(direction * power);
        forcedObj.gravityScale = gravScale;
    }
}
