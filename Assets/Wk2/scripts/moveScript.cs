using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public float speed;


    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        transform.position = position;

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Translate(Vector2.up* speed * Time.deltaTime);

        //}

        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(Vector2.down * speed * Time.deltaTime);
        //}
    }

}
