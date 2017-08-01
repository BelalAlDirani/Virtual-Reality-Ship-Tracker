﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

	public void LoadLevel(string sceneToLoad)
    {
        StartCoroutine(gameController.control.LoadLevel(sceneToLoad));
    }
}
