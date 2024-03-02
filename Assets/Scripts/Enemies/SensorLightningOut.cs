using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorLightningOut : MonoBehaviour
{

    public Animator Lightning;
    public BoxCollider2D BoxCollider;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Lightning.SetBool("PlayerPassed", true);
            BoxCollider.enabled = false;
        }
    }
}
