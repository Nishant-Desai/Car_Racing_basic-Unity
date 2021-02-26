using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIcarMovement : MonoBehaviour
{
    public GameObject Tracker;

    public GameObject waypoint1;
    public GameObject waypoint2;
    public GameObject waypoint3;
    public GameObject waypoint4;
    public GameObject waypoint5;
    public GameObject waypoint6;
    public GameObject waypoint7;
    public GameObject waypoint8;
    public GameObject waypoint9;
    public GameObject waypoint10;
    public GameObject waypoint11;
    public GameObject waypoint12;
    public GameObject waypoint13;
    public GameObject waypoint14;
    public GameObject waypoint15;
    public GameObject waypoint16;
    public GameObject waypoint17;
    public GameObject waypoint18;
    public GameObject waypoint19;

    public int currentwaypoint;

    // Update is called once per frame
    void Update()
    {
        if(currentwaypoint==0)
        {
            Tracker.transform.position = waypoint1.transform.position;
        }
        if (currentwaypoint == 1)
        {
            Tracker.transform.position = waypoint2.transform.position;
        }
        if (currentwaypoint == 2)
        {
            Tracker.transform.position = waypoint3.transform.position;
        }
        if (currentwaypoint == 3)
        {
            Tracker.transform.position = waypoint4.transform.position;
        }
        if (currentwaypoint == 4)
        {
            Tracker.transform.position = waypoint5.transform.position;
        }
        if (currentwaypoint == 5)
        {
            Tracker.transform.position = waypoint6.transform.position;
        }
        if (currentwaypoint == 6)
        {
            Tracker.transform.position = waypoint7.transform.position;
        }
        if (currentwaypoint == 7)
        {
            Tracker.transform.position = waypoint8.transform.position;
        }
        if (currentwaypoint == 8)
        {
            Tracker.transform.position = waypoint9.transform.position;
        }
        if (currentwaypoint == 9)
        {
            Tracker.transform.position = waypoint10.transform.position;
        }
        if (currentwaypoint == 10)
        {
            Tracker.transform.position = waypoint11.transform.position;
        }
        if (currentwaypoint == 11)
        {
            Tracker.transform.position = waypoint12.transform.position;
        }
        if (currentwaypoint == 12)
        {
            Tracker.transform.position = waypoint13.transform.position;
        }
        if (currentwaypoint == 13)
        {
            Tracker.transform.position = waypoint14.transform.position;
        }
        if (currentwaypoint == 14)
        {
            Tracker.transform.position = waypoint15.transform.position;
        }
        if (currentwaypoint == 15)
        {
            Tracker.transform.position = waypoint16.transform.position;
        }
        if (currentwaypoint == 16)
        {
            Tracker.transform.position = waypoint17.transform.position;
        }
        if (currentwaypoint == 17)
        {
            Tracker.transform.position = waypoint18.transform.position;
        }
        if (currentwaypoint == 18)
        {
            Tracker.transform.position = waypoint19.transform.position;
        }
    }

    private IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag=="AI_car")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            currentwaypoint += 1;
            if(currentwaypoint==19)
            {
                currentwaypoint = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }

}
