using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5.7f;

    Vector3 playerInput;

    Rigidbody rb;
    


    private void Awake() => rb = GetComponent<Rigidbody>();


    private void Update() => PlayerInput();


    private void FixedUpdate() => Movement();




    private void PlayerInput()
    {
        //Gets the Input values of each access
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.z = Input.GetAxisRaw("Vertical");

        //Makes sure the Vector3 has a magnitude of 1  (prevents diagonal movement being faster than other directions)
        playerInput.Normalize();

    }

    //Moves the Player
    private void Movement()
    {
        rb.MovePosition(rb.position + getGroundNormalRotation() * playerInput * speed * Time.fixedDeltaTime);
    }

    //used to calculate what direction force should be applied to during movement (this is to make traversing slopes smoother)
    private Quaternion getGroundNormalRotation()
    {
        RaycastHit hit;
        Vector3 groundNormal;
        
        //sends a raycast at the ground and stores it in hit
        Physics.Raycast(rb.position, -Vector3.up, out hit);
        //gets the normal of the ground  aka which way the ground is facing
        groundNormal = hit.normal;

        //returns the angle from transform.up to the direction the normal is facing
        return Quaternion.FromToRotation(transform.up, groundNormal);
    }
}
