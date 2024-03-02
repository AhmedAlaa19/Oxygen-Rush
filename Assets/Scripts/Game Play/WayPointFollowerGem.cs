using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollowerGem : MonoBehaviour
{
    [SerializeField] private GameObject waypointParent;
    private int currentWaypointIndex = 0;
    [SerializeField] private Rigidbody2D rB;
    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(waypointParent.transform.GetChild(currentWaypointIndex).position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypointParent.transform.childCount)
            {
                currentWaypointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypointParent.transform.GetChild(currentWaypointIndex).position, Time.deltaTime * speed);
    }



    /* private void Rotate()
    {
        transform.Rotate(0, 0, 360 * rotSpeed * Time.deltaTime);
    }*/
}
