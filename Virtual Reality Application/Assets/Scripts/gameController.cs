using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {


    public static gameController control;
    public  GameObject cameraFly;
    public GameObject audioSource;

    void Awake()
    {
        control = this;
    }
	// Use this for initialization
	void Start () {
      

        StartCoroutine(LoadLevel("BrowsePlaylist"));

		
	}
	
	public IEnumerator LoadLevel(string sceneName)
    {
        yield return new WaitForEndOfFrame();

        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        StartCoroutine(UnloadLevels(sceneName));


    }

    private IEnumerator UnloadLevels(string exception)
    {
        yield return new WaitForEndOfFrame();

        for(int i = 0; i < SceneManager.sceneCount; ++i)
        {
            if(SceneManager.GetSceneAt(i).name != exception && SceneManager.GetSceneAt(i).name != "VRMain")
            {
                SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(i).name);
            }

            if (SceneManager.GetSceneAt(i).name == "AISDataCanvas")
            {
                cameraFly.GetComponent<Fly>().enabled = true;
            }

            
        }
    }

}
