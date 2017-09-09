using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GVR;


//in order for script to work CharacterController on object must be required
[RequireComponent(typeof(CharacterController))]
public class Fly : MonoBehaviour {
    
    //public for runtime testing 
    public float moveSpeed = 3.0f;

    //true or false if controller is touched or screen is touched 
    //public for testing purposes
    public bool moveForward;

    //allows for movements by calling Move function, not effected by rigidbody
    private CharacterController Controller;

    //main gvr
    private GvrEditorEmulator gvrViewer;

    //head of the gvr emulator
    private Transform vrHead;
  
	// Use this for initialization
	void Start () {

        //assign controller to CharacterController component attached to GVRMain
        Controller = GetComponent<CharacterController>();

        //sets the gvrViewer to the gvr emulator
        gvrViewer = transform.GetChild(0).GetComponent<GvrEditorEmulator>();

        //allows the vrHead camera to be manipulated
        vrHead = Camera.main.transform;

    }
	
	// Update is called once per frame
	void Update () {

        //checks if screen is touched, or controller is touched
        if (Input.GetButtonDown("Fire1") || GvrController.TouchDown)
        {
            //sets moveForward to true and false
            moveForward =  !moveForward;
        }

        //if moveForward is true
        if (moveForward)
        {
            //transform the vrHead to a forward dirtection
            Vector3 forward = vrHead.TransformDirection(Vector3.forward);

            //calls Move function that sets the forward speed of the vrHead
            Controller.Move(forward * moveSpeed * Time.deltaTime);
        }
       
		
	}
    
}
