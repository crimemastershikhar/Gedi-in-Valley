using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Summary: Responsible to follow the car

public class CameraController : MonoBehaviour {

    [SerializeField] private Transform target;

    private void FixedUpdate() {
        Vector3 newPosition = target.position;
        newPosition.z = -10;

        transform.position = newPosition;
    }















}//Class
