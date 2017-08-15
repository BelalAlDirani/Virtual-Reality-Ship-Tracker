using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour {

    public int knot = 5, rotation = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * knot);
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * rotation);
		
	}
}
