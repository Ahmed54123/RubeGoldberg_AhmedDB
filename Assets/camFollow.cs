using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{

    public GameObject followObj;
    public float newCamSizeMultiplier;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 newCamPos = new Vector3(followObj.gameObject.transform.position.x, followObj.gameObject.transform.position.y, Camera.main.transform.position.z);
        Camera.main.transform.position = newCamPos;
        


    }
}
