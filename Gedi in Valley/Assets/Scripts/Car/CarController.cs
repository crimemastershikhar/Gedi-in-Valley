using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CarController : MonoBehaviour {

    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private WheelJoint2D backWheel;
    [SerializeField] private WheelJoint2D frontWheel;

    [SerializeField] private Rigidbody2D rb;

    private float movement;
    private float rotation;

    private void Update() {
        movement = -Input.GetAxisRaw("Vertical") * speed;

        rotation = Input.GetAxisRaw("Horizontal") * rotationSpeed;
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

        rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
    }




















}//Class
