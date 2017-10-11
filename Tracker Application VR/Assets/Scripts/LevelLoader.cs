using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

    //function for which scene to load
	public void LoadLevel(string sceneToLoad)
    {
        //calls coroutine from gameController Class for which scene to load
        StartCoroutine(gameController.control.LoadLevel(sceneToLoad));
    }
}
