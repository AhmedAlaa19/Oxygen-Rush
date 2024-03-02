using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsManager : MonoBehaviour
{
   public static bool disableCameraAnimation = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableCam()
    {
        if (!disableCameraAnimation)
        {
            disableCameraAnimation = true;
            Debug.Log("Disabled");
        }
        else

        {
            disableCameraAnimation = false;
            Debug.Log("Enabled");
        }
    }
}
