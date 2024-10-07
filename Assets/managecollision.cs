using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Managecollision : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private SpawnPipe spawner;

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //Set score to 0
            //Move bird to initial position
            //Destroy all pipes
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Score"))
        {
            //increase score by 1
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
