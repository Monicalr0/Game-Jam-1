using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float xMovement;
    private float yMovement;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
 
        xMovement = movementVector.x;
        yMovement = movementVector.y;
    }
    


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddRelativeForce(new Vector3(xMovement, 0, yMovement) * speed);
        if (transform.position.y != 0) {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
    }
}
