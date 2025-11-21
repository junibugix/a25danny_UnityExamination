using System;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject player;
    public GameObject cam;

    
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > cam.transform.position.x + 3)
        {
            cam.transform.position = new Vector3(cam.transform.position.x + 15 * Time.deltaTime, cam.transform.position.y, -10);
        }
        else if (player.transform.position.x < cam.transform.position.x - 3)
        {
            cam.transform.position = new Vector3(cam.transform.position.x - 15 * Time.deltaTime, cam.transform.position.y, -10);
        }
        
        if (player.transform.position.y > cam.transform.position.y + 3)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + 15 * Time.deltaTime, -10);
        }
        else if (player.transform.position.y < cam.transform.position.y - 3)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - 15 * Time.deltaTime, -10);
        }
    }
}
