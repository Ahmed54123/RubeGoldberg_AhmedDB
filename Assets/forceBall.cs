using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceBall : MonoBehaviour
{
    Rigidbody2D ballRB;

    void Start()
    {
        ballRB = gameObject.GetComponent<Rigidbody2D>();

        ballRB.AddForce(Vector2.right * 4000);

    }

    void Update()
    {
        
    }
}
