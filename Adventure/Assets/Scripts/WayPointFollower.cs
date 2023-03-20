using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    private int CurrentWayPointIndex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(wayPoints[CurrentWayPointIndex].transform.position,transform.position)<.1f)
        {
            CurrentWayPointIndex++;
            if(CurrentWayPointIndex>=wayPoints.Length)
            {
                CurrentWayPointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[CurrentWayPointIndex].transform.position, Time.deltaTime * speed);
    }
}
