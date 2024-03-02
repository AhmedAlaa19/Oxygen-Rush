using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] WayPointFollower script;
    void Start()
    {
        script.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        script.enabled = true;
    }
}
