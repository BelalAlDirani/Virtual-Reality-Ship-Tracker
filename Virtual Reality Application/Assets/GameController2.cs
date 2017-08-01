using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController2 : MonoBehaviour
{


    public static GameController2 control;


    void Awake()
    {
        control = this;
    }
    // Use this for initialization
    void Start()
    {
        StartCoroutine(LoadLevel("AISDataCanvas"));


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

        for (int i = 0; i < SceneManager.sceneCount; ++i)
        {
            if (SceneManager.GetSceneAt(i).name != exception)
            {
                SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(i).name);
            }
        }
    }

}
