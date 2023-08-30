using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This variable is used when recieving a Game Over
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name == "Player")
        {
            transform.position = new Vector3(0, 20.0f, 0);
        }
    }
}
