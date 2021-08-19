using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigit;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rigit = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rigit.velocity = new Vector3(horizontalInput * movementSpeed, rigit.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump")) {
            rigit.velocity = new Vector3(rigit.velocity.x, jumpForce, rigit.velocity.z);    
        }
        
    }
}
