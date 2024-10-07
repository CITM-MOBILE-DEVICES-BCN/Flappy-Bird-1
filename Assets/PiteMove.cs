using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiteMove : MonoBehaviour
{
    [SerializeField] private float speedPipe = 1.0f;
    void Update()
    {
        transform.position += Vector3.left * speedPipe * Time.deltaTime;



    }
}
