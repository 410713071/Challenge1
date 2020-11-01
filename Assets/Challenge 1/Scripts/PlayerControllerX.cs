using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float HorizontalInput;
    public float flipInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");
        flipInput = Input.GetAxis("flip");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput+ Vector3.up * rotationSpeed * Time.deltaTime * HorizontalInput + Vector3.back * rotationSpeed * 0.7f * Time.deltaTime * flipInput);
    }
}
