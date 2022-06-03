using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    CharacterController controller;
    [SerializeField]
    float gravity = 1.0f;
    [SerializeField]
    float y_velocity = 0.0f;
    [SerializeField]
    float _jumpspeed = 50.0f;
    [SerializeField]
    float movespeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 velocity = direction * movespeed;
        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                y_velocity = _jumpspeed;
            }
        }
        else
        {
            y_velocity -= gravity;

        }
        velocity.y = y_velocity;
        velocity = transform.TransformDirection(velocity);
        controller.Move(velocity * Time.deltaTime);


    }
}
