using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instFireTrail : MonoBehaviour
{
    public GameObject asteroidTrail;
    GameObject currentAsteroidTrail;

    Rigidbody2D probeRB;
    void Start()
    {
        probeRB = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(probeRB.gravityScale > 0)
        {
            currentAsteroidTrail = Instantiate(asteroidTrail, gameObject.transform.position, Quaternion.identity);
        }

        if(probeRB.gravityScale > 1)
        {
            Destroy(currentAsteroidTrail);
        }
    }
}
