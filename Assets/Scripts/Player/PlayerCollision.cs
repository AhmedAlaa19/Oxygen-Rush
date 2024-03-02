using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Animator animator;
    public PlayerMovement PlayerMovement;
    [SerializeField] private AudioSource Deathsfx;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            PlayerMovement.Death();

        }
    }
}
