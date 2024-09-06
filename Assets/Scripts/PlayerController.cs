using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    private Camera activeCamera;

    private float turnSpeed = 5f;
    private float speed = 20f;

    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        activeCamera = camera1;
        camera1.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicule
        transform.Translate(speed * Time.deltaTime * verticalInput * Vector3.forward);
        transform.Rotate(horizontalInput * Time.deltaTime * turnSpeed * Vector3.up);

        // Camera Switcher
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (activeCamera == camera1)
            {
                activeCamera = camera2;

                camera1.enabled = false;
                camera2.enabled = true;
            }

            else
            {
                activeCamera = camera1;

                camera1.enabled = true;
                camera2.enabled = false;
            }
        }

        
    }
}
