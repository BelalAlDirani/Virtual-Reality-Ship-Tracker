using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeDisappear : MonoBehaviour {

    public GameObject welcome;
    private bool isShowing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown("Fire1") || GvrController.TouchDown)
        {
            isShowing = !isShowing;
            welcome.SetActive(isShowing);

        }
		
	}
}
