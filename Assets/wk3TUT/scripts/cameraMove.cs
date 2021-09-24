using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraMove : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        



    }

    private void OnTriggerEnter2D(Collider2D camCollider)
    {
        if (camCollider.gameObject.tag == "cameraCollide")
        {
            if (camCollider.gameObject.name == "CamPos2")
            {
                SceneManager.LoadScene("2DcolliderTutorial");
            }

            else
            {
                Vector3 newCamPos = new Vector3(camCollider.gameObject.transform.position.x, camCollider.gameObject.transform.position.y, Camera.main.transform.position.z);
                Camera.main.transform.position = newCamPos;
            }
        }


    }
}
