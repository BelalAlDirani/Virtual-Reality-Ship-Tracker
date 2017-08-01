using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAtUser : MonoBehaviour {

    public new Camera camera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (camera == null)
        {
            camera = Camera.main;
        }
        transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);
    }
}
