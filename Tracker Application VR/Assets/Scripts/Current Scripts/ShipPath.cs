using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPath : MonoBehaviour {

    public Transform[] path;
    public float speed;

    private int current;
	// Use this for initialization
	void Start () { 

    }
	
	// Update is called once per frame
	void Update () {
    
        //ship moves until reached end of waypoint
        if (transform.position != path[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, path[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);

        }
        else 
        {
            current = (current + 1) % path.Length;
        }

    }
}
