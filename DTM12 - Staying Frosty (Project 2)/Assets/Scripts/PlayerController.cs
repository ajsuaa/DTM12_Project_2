using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Important - This allows the buttons to transfer the user to different scenes
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Determines the speed of the player
    private float speed = 20.0f;

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


    //This variable is used when recieving a Game Over
    private void OnCollisionEnter(Collision other)
    {
        // When player collides with red walls, transfer user to Build Scene 2 (Game Over Scene)
        if (other.gameObject.name == "Wall")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }



}
