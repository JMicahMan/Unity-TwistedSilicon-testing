using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadiCarBehaviour : MonoBehaviour {

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
    public GameObject waypoint20;
    public GameObject waypoint21;
    public GameObject waypoint22;
    public GameObject waypoint23;
    public GameObject waypoint24;
    public GameObject waypoint25;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.position = waypoint1.transform.position;

        if (transform.position == waypoint1.transform.position)
        {
            transform.position = waypoint2.transform.position;
            if (transform.position == waypoint2.transform.position)
            {
                transform.position = waypoint2.transform.position;
                if (transform.position == waypoint1.transform.position)
                {
                    transform.position = waypoint2.transform.position;
                }

            }

        }
    }
}
