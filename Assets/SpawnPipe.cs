using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
   [SerializeField] private float TimeOfSpawn = 2.0f;
    [SerializeField] private float RangeOfThePipe = 0.5f;
    [SerializeField] private GameObject pipe;

    private float timer;

    private void Start()
    {
        Spawn();
    }

    private void Update()
    {
        if(timer > TimeOfSpawn)
        {
            Spawn();
            timer = 0;
        }

        timer += Time.deltaTime;
    }
    private void Spawn()
    {

        Vector3 PositionofSpawn = transform.position + new Vector3(0, Random.Range(RangeOfThePipe, -RangeOfThePipe));
        GameObject PIPE = Instantiate(pipe,PositionofSpawn, Quaternion.identity);

        Destroy(PIPE, 20.0f);


    }


}
