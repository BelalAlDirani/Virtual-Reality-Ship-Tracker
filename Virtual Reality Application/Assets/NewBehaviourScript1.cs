using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript1 : MonoBehaviour {

    public GameObject cameraFly;
    // Use this for initialization
    void Start () {

        if (Application.loadedLevelName == "AISDataCanvas")
        {
            cameraFly.GetComponent<Fly>().enabled = true;
        }
           


        
            
        
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
