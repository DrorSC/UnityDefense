using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;

    private Transform target;

	// Use this for initialization
	void Start () {
        target = Waypoint.endPoint;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 dir = target.position - transform.position;
        // delta time used to not be dependant on frame rate 
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position,  target.position) <= 0.2f)
        {
            // Reached END - TODO: Lose points?
            Destroy(gameObject);
        }
	}
}
