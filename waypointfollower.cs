using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointfollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    
    private float oldPosZ;
    private Animator anim;
    private float oldPosX;

    [SerializeField] private float speed = 2f;
    private void Start()
    {
        oldPosX = transform.position.x;
        oldPosZ = transform.position.z;
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (oldPosX < transform.position.x)
        {
            
            anim.SetFloat("Horizontal", -1);
            oldPosX = transform.position.x;
        }
        else if (oldPosX > transform.position.x)
        {
            
            anim.SetFloat("Horizontal", 1);
            oldPosX = transform.position.x;
        }
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < 0.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
