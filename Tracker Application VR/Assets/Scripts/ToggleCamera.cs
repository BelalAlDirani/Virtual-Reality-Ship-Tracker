using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCamera : MonoBehaviour {

    public GameObject vr1;
    public GameObject vr2;
	// Use this for initialization
	void Start () {

       
		
	}
	
	// Update is called once per frame
	void Update () {

        vr2.SetActive(true);
        //vr1.SetActive(false);
    }
}
