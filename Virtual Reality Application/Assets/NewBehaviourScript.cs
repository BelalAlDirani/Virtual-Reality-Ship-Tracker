using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/ais_voyages_dynamic.php?passwd=dJHSRzhqu4&session=314"; //{"message":"hello!"}
    private WWW www = null;

    void Start()
    {
        www = new WWW(url);
        StartCoroutine(ReceiveResponse());
    }

    private IEnumerator ReceiveResponse()
    {
        yield return www;

        JSONObject json = new JSONObject(www.text);
        Debug.Log(json.GetField("idmessage").str);
    }
}


