using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    [SerializeField] private float speed;

    [SerializeField] private WheelJoint2D backWheel;
    [SerializeField] private WheelJoint2D frontWheel;

    private float movement;


    private void Update() {
        movement = -Input.GetAxisRaw("Vertical") * speed;

    }

    private void FixedUpdate() {

        if (movement == 0f) {
            backWheel.useMotor = false;
            frontWheel.useMotor = true;

        } else {
            backWheel.useMotor = frontWheel.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = backWheel.motor.maxMotorTorque };
            backWheel.motor = frontWheel.motor = motor;

        }

    }




















}//Class
