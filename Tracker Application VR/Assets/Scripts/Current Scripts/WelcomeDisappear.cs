using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeDisappear : MonoBehaviour {

    //set the canvas object to variable welcome
    public GameObject welcome;

    //check if screen is touched
    private bool isShowing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if(Input.GetButtonDown("Fire1") || GvrController.TouchDown)
        {
            //if screen is touched isShowing is set to false
            isShowing = !isShowing;

            //set welcome object (canvas) to not show
            welcome.SetActive(isShowing);

        }
		
	}
}
