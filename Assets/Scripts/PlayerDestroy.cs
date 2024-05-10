using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        
        Debug.Log(other.gameObject.tag);

        if(other.gameObject.tag == "Player") {
            // When you want to get rid of an game object, you DESTROY it
            Destroy(other.gameObject);
        }

    }

}
