using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorLightningIn : MonoBehaviour
{
    public Animator Lightning;


    // Start is called before the first frame update
    void Start()
    {
        Lightning.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Lightning.enabled = true; 
        }
    }
}
