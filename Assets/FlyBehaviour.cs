using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;
using Cinemachine;

public class FlyBehaviour : MonoBehaviour
{

    [SerializeField] private float velocity = 160.5f;
    [SerializeField] private float rotationSpeedNormal = 4f;
    [SerializeField] private float rotationSpeedFirstperson = 0.5f;
    private float rotationSpeedFinal;
    public Rigidbody rb;

    public CameraChangin cameraManager;


    private void Start()
    {

        rotationSpeedFinal = rotationSpeedFirstperson;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    private void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(0f, velocity, 0f), ForceMode.Acceleration);

        }
        rb.position = new Vector3(0.0f, rb.position.y, rb.position.z);

        rb.rotation = transform.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * rotationSpeedFinal);
        //Quaternion aim = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * rotationSpeed);
        //rb.AddForce(aim*Vector3.forward);



        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            cameraManager.SwitchCamera(cameraManager.firstPersonCam);
            rotationSpeedFinal = rotationSpeedFirstperson;

        }

        if (Keyboard.current.vKey.wasPressedThisFrame)
        {
            cameraManager.SwitchCamera(cameraManager.NormalCam);
            rotationSpeedFinal = rotationSpeedNormal;
        }

    }
}
