using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAtUser : MonoBehaviour {

    //Camera at runtime
    public new Camera camera;
    // Use this for initialization


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //if no camera exists at runtime
        if (camera == null)
        {
            //create a camera
            camera = Camera.main;
        }

        //rotate world space canvas to cameras position
        transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);
    }
}
