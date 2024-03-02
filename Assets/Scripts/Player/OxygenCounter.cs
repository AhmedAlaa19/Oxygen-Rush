using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OxygenCounter : MonoBehaviour
{
    private bool hasMoved = false;
    public PlayerMovement playerMovement;
    float currentOxygen;
    float startingOxygen = 10;
    public Animator animator;
    [SerializeField] private Text oxygenText;
    public Rigidbody2D player;
    public bool withStop;
    public int chkMv = 1;
    public int chkMvWStop = 2;
   


    private void Start()
    {
        currentOxygen = startingOxygen;

        

    }

    private void Update()
    {

        if (withStop)
        {
            CheckMovementWithStop();
        }
        else
        {
            CheckMovement();
        }
    }

    private void CheckMovement()
    {


        if (!hasMoved && (player.velocity.x > 0.01 || player.velocity.y > 0.01))
        {
            hasMoved = true;
        }

        if (hasMoved)
        {
            currentOxygen -= chkMv * Time.deltaTime;
            oxygenText.text = currentOxygen.ToString("0");


            if (currentOxygen <= 0)
            {
                playerMovement.Death();
       
            }
        }
    }
    private void CheckMovementWithStop()
    {


        if (!hasMoved && (player.velocity.x > 0.01 || player.velocity.y > 0.01))
        {
            hasMoved = true;
        }
        else
        {
            hasMoved = false;
        }

        if (hasMoved)
        {
            currentOxygen -= chkMvWStop * Time.deltaTime;
            oxygenText.text = currentOxygen.ToString("0");


            if (currentOxygen <= 0)
            {
                playerMovement.Death();


            }
        }

    }
}




