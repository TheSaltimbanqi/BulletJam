using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject camera;

    public float cameraRange;

    private void Start()
    {
        if(camera==null)
        {
            camera = Camera.main.gameObject;
        }
    }

    private void Update()
    {
        camera.transform.position = transform.position + (Vector3.forward * cameraRange);
    }
}
