using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCameraFollow : MonoBehaviour
{
    public camFollow MainCameraFollow;
    public GameObject objToFollow;
    public float newCamSizeMultiplier;
    void Start()
    {
        MainCameraFollow = MainCameraFollow.GetComponent<camFollow>();
    }

    void Update()
    {
        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "changeCam")
        {
            MainCameraFollow.followObj = objToFollow;
            Camera.main.orthographicSize = Camera.main.orthographicSize * newCamSizeMultiplier;
        }
    }
}
