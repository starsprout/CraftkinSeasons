using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5.7f;

    Vector3 playerInput;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        PlayerInput();


        
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void PlayerInput()
    {

        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.z = Input.GetAxisRaw("Vertical");

        playerInput.Normalize();

    }

    private void Movement()
    {
        rb.MovePosition(rb.position + playerInput * speed * Time.fixedDeltaTime);
    }
}
