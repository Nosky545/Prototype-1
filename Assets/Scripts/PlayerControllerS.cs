using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerS : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Variables
    public float turnSpeed = 5f;
    public float speed = 20f;

    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Inputs
        horizontalInput = Input.GetAxis("HorizontalS");
        verticalInput = Input.GetAxis("VerticalS");

        // Move the vehicule
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
