using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

    //public for LevelLoader accessability
    public static gameController control;

    //object VR Camera
    public  GameObject GvrCamera;

    //object audioSource
    public GameObject audioSource;

    void Awake()
    {
        control = this;
    }
	// Use this for initialization
	void Start () {

        //start app with BrowsePlaylist scene
        StartCoroutine(LoadLevel("MainMenu"));

		
	}
	
    //call LoadLevel function from LevelLoader Class
	public IEnumerator LoadLevel(string sceneName)
    {
        //yield result wait for Coroutine to finish execution 
        yield return new WaitForEndOfFrame();

        //loads scene 
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);


        //unloads scene
        StartCoroutine(UnloadLevels(sceneName));


    }

    //unload Levels or scenes in application
    private IEnumerator UnloadLevels(string exception)
    {
   
        yield return new WaitForEndOfFrame();

        //for how mnay scenes there are in the application + i
        for(int i = 0; i < SceneManager.sceneCount; ++i)
        {
            //checks scene at nth position but not VRMain scene
            if(SceneManager.GetSceneAt(i).name != exception && SceneManager.GetSceneAt(i).name != "VRMain")
            {
                //unloads that particular scene
                SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(i).name);
            }

            //if current scene is AISDataCanvas
            /*if (SceneManager.GetSceneAt(i).name == "AISDataCanvas")
            {
                //Enable the Fly script
                //cameraFly.GetComponent<Fly>().enabled = true;
            }*/

            //if the current scene is MapBoxAllShips
            if (SceneManager.GetSceneAt(i).name == "MapBoxAllShips")
            {
                //Disable the GVRMain Camera Component
                GvrCamera.SetActive(false);
            }

            if (SceneManager.GetSceneAt(i).name == "ScenarioMenu")
            {
                //Enable the GVRMain Camera Component
                GvrCamera.SetActive(true);
           
            }


        }
    }

}
