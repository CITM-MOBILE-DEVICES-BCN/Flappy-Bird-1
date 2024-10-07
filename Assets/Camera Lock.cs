using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class CameraLock : MonoBehaviour
{



    [SerializeField] private float rotationCameraSpeed = 2f;
    [Header("Rigidbody Camera")]
    [SerializeField] public FlyBehaviour flyb;

        



    // Update is called once per frame

    private void Update()
    {
     
       
        transform.rotation = transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }


}
