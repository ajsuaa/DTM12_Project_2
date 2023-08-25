using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Important - This allows the buttons to transfer the user to different scenes
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Determines the speed of the player
    private float speed = 20.0f;

    public GameObject parentWindows;
    public GameObject parentDoors;
    public float test;

    //Provides the  Rigidbody a variable
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    //Moves the player based on arrow key input
    void MovePlayer()
    {
        //How the player is controlled (going horizontally and vertically,  move, left, up, down)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Applying the speed when controlling the player
        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.IsChildOf(parentWindows.transform))
        {
            //collisionObject = collision.gameObject;
            //collisionObject.transform

            // raose the window
            // update the temperature so its not increaing so fast.
          }
    }


    //A variable that makes the player interact with the objects
}
