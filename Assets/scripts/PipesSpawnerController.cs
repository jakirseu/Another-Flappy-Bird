using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawnerController : MonoBehaviour
{


    public float maxTime = 2;
    public GameObject pipes;
    private float timer;
    public float height = 1;

    void Update()
    {

        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipes);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;

    }
}
