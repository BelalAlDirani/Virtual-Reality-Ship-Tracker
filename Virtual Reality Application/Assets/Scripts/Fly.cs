using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GVR;

[RequireComponent(typeof(CharacterController))]
public class Fly : MonoBehaviour {

    public float moveSpeed = 3.0f;

    public bool moveForward;

    private CharacterController Controller;

    private GvrEditorEmulator gvrViewer;

    private Transform vrHead;
  
	// Use this for initialization
	void Start () {

        Controller = GetComponent<CharacterController>();

        gvrViewer = transform.GetChild(0).GetComponent<GvrEditorEmulator>();

        vrHead = Camera.main.transform;

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1") || GvrController.TouchDown)
        {
            moveForward =  !moveForward;
        }

        if (moveForward)
        {

            Vector3 forward = vrHead.TransformDirection(Vector3.forward);

            Controller.Move(forward * moveSpeed * Time.deltaTime);
        }
       
        
		
	}

    
}
