using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    // Fields

    // Starting location
    public Transform startingLocation;

    // Object to generate ( Pipe )
    public GameObject pipe;
    // public GameObject pipContainer;

    // Time
    public float spawnTime;
    float countdown;

    // Min and Max Height
    public float minGapHight;
    public float maxGapHight;

    // Start is called before the first frame update
    void Start()
    {
        // Create a new instance of the pipe at the starting location
        // Keyword: Instantiate(object)
        countdown = spawnTime;

    }



    // Update is called once per frame
    void Update()
    {

        if(countdown > 0) {
            countdown -= Time.deltaTime;
        } 
        else {

            GeneratePipe();
            countdown = spawnTime;
        }
    }

    void GeneratePipe() {
        GameObject newPipe = Instantiate(pipe);
        // pipContainer.transform.SetParent(newPipe.transform);
        newPipe.transform.position = startingLocation.position;

        float randomHeight = Random.Range(minGapHight, maxGapHight);
        Vector3 newHeight = new Vector3(0, randomHeight, 0);
        newPipe.transform.position += newHeight;

    }

}
