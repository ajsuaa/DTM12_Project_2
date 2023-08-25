using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject parent;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        //The camera's X and Z axis change depending on the player's position in order to follow, while the Y axis of the camera remains the same
        transform.position = player.transform.position + new Vector3(0, 19, 0);
    }

    
}


