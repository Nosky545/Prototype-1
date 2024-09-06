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
    private float horsePower = 20f;

    private float horizontalInput;
    private float verticalInput;

    private Rigidbody playerRb;

    public TextMeshProUGUI speedometerText;
    public float speed;

    public TextMeshProUGUI rpmText;
    public float rpm;

    // Start is called before the first frame update
    void Start()
    {
        activeCamera = camera1;
        camera1.enabled = true;
        camera2.enabled = false;
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicule
        playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
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

    void Update()
    {
        speed = Mathf.Round(playerRb.velocity.magnitude * 3.6f);
        speedometerText.text = "Speed: " + speed + "kph";

        rpm = Mathf.Round(speed % 30 * 40);
        rpmText.text = "RPM: " + rpm;
    }
}
