using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float acceleration = 0.1f;
    //[SerializeField] KeyCode forwardButton = KeyCode.UpArrow;

    [SerializeField] float angularSpeed = 90;
    [SerializeField] float maxSpeed = 5;

    [SerializeField] float drag = 0.8f;


    Vector3 velocity;

    void FixedUpdate()
    {
        //bool forward = Input.GetKey(forwardButton);
        float forwardInput = Input.GetAxis("Vertical");

        if (forwardInput > 0)
        {
            Vector3 direction = transform.up;
            velocity += direction * acceleration * Time.fixedDeltaTime;
        }

        float currentSpeed = velocity.magnitude;

        if (currentSpeed > maxSpeed)
        {
            velocity.Normalize();
            velocity *= maxSpeed;
        }
        
        transform.position += velocity * Time.fixedDeltaTime;

        //Forgás--------------------------------------------------
        float rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, - rotationInput * angularSpeed * Time.fixedDeltaTime);

        //lassulás
        velocity *= 1 - (drag * Time.fixedDeltaTime);

    }
}
