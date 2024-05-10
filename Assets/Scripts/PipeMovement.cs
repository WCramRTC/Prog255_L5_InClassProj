using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float pipeSpeed;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Have the pipe move to the left
        // On the x axis -
        // Vector3(x,y,z)
        // Vector3(-1,0,0)

        transform.Translate(Vector3.left * Time.deltaTime * pipeSpeed);
    }
}
