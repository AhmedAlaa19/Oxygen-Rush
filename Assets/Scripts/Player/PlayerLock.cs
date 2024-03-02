using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLock : MonoBehaviour
{
    public PlayerMovement PlayerMovement;

    public void Lock()
    {
        PlayerMovement.enabled = false;
    }

    public void UnLock()
    {
        PlayerMovement.enabled = true;
           
    }
}
