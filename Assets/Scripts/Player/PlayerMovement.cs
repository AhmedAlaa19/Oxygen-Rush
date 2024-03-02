using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // References to other components
    public PlayerMovement playerMovement; // This variable seems unnecessary
    public Animator animator; // Reference to the animator component
    public CharacterController2D controller; // Reference to the CharacterController2D component
    public bool soundPlayed =  false;

    [SerializeField] private AudioSource jumpsfx;
    [SerializeField] private AudioSource Deathsfx;
    // Movement variables
    public float horizontalMove = 0f; // Horizontal movement input
    public float runSpeed = 40f; // Speed at which the player moves
    public bool jump = false; // Whether the player should jump

    // Update is called once per frame
    void Update()
    {
        // Get horizontal movement input
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        // Set the "Speed" parameter in the animator to control animation
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        // Check if jump button is pressed
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true); // Set the "IsJumping" parameter to trigger jump animation
            jumpsfx.Play();
        }

        
        Falling(); // Check if the player is falling
    }

    // Called when the character lands after a jump (used by the CharacterController2D)
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false); // Reset jump animation state
    }

    // Check if the player is falling below the ground
    public void Falling()
    {
        if (transform.position.y < 0) // If player's y position is below 0
        {
            Death();
            
        }
    }

    private void FixedUpdate()
    {
        // Move the character using the CharacterController2D's Move function
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false; // Reset jump after the FixedUpdate
    }

    public void Death()
    {
        animator.SetBool("IsDead", true); // Set the "IsDead" parameter to trigger death animation
        playerMovement.enabled = false; // Disable player movement
        FindObjectOfType<GameManager>().EndGame(); // Find the GameManager and call the EndGame function
        if(playerMovement.enabled == false && !soundPlayed)
        {
            Deathsfx.Play();
            soundPlayed = true;

        }
    }
}
