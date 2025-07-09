using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float highOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
            timer += Time.deltaTime;
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - highOffset;
        float highestpoint = transform.position.y + highOffset;

        var randomPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestpoint), 0);

        Instantiate(pipe, randomPosition, transform.rotation);
    }
}
