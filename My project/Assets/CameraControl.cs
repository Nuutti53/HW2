using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
      public GameObject Camera;
    //public Transform CameraMag;
    //public Transform MagGlass;
    //public Transform Target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var CamToGlass = Camera.transform.position - MagGlass.transform.position;
        Vector3 Camerarot;
        Camerarot = Camera.transform.forward;
    }
}
