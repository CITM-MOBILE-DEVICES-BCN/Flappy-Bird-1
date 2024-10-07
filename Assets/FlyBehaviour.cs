using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;


public class FlyBehaviour : MonoBehaviour
{

    [SerializeField] private float velocity = 160.5f;
    [SerializeField] private float rotationSpeed = 10.5f;
    public Rigidbody rb;





    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.AddForce(new Vector3(0f, velocity, 0f), ForceMode.Acceleration);

        }
        rb.position = new Vector3(0.0f , rb.position.y, rb.position.z);

        rb.rotation = transform.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * rotationSpeed);
        //Quaternion aim = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * rotationSpeed);
        //rb.AddForce(aim*Vector3.forward);

    }
  
    
}
