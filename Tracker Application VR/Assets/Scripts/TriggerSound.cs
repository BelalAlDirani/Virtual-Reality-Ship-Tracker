using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerSound : MonoBehaviour {

	public bool mute;
	AudioSource audioSource; 
	// Use this for initialization
	void Start () {
        //Get the audio source component
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
        //If cardboard button is triggered
		if (Input.GetButton("Fire1")) 
		{
            //Audio source is unmuted
			audioSource.mute = !audioSource.mute;
		}
	}
}
