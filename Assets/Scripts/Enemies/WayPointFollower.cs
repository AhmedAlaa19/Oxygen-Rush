using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    [SerializeField] private Rigidbody2D rB;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);

        if (rB.velocity.y > 0.1f)
        {
            spriteRenderer.flipY = false; // Flip sprite back to default
        }
       
        else if (rB.velocity.y < -0.1f)
        {
            spriteRenderer.flipY = true; // Flip sprite vertically
        }

    }


     
}
