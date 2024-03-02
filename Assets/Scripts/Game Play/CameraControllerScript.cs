using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
   
    public Animator cameraAnimator;

    // Start is called before the first frame update
    void Start()
    {
        if (OptionsManager.disableCameraAnimation)
        {
            cameraAnimator.SetBool("Cam Disabled", true);
        }
        else
        {
            // Play the camera animation
            cameraAnimator.SetBool("Cam Disabled", false);
        }
    }


    
}
