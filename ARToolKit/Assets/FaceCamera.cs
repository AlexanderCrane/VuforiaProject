using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour {

    Camera ARCam;

    void Update () {
        ARCam = Camera.main;
        transform.LookAt(transform.position + ARCam.transform.rotation * Vector3.forward, ARCam.transform.rotation * Vector3.up);
    }
}
