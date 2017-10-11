using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerSound : MonoBehaviour {

	public bool mute;
	AudioSource audioSource; 
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1")) 
		{
			audioSource.mute = !audioSource.mute;
		}
	}
}
