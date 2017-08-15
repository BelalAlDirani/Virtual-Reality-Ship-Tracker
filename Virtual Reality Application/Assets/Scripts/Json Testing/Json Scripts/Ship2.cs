using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Ship2 : MonoBehaviour {

    string path;
    string jsonstring;
    private Text text;

    public object ShipDynamicDataList { get; private set; }

    void Start()
    {


        path = Application.streamingAssetsPath + "/shipStatic.json";
        jsonstring = File.ReadAllText(path);
        shipStaticDataList ShipStaticDataList = new shipStaticDataList();
        JsonUtility.FromJsonOverwrite(jsonstring, ShipStaticDataList);


        path = Application.streamingAssetsPath + "/shipDynamic.json";
        jsonstring = File.ReadAllText(path);
        shipDynamicDataList ShipDynamicDataList = new shipDynamicDataList();
        JsonUtility.FromJsonOverwrite(jsonstring, ShipDynamicDataList);


        // AIS TEXT CANVAS FOR SHIP[0]

        /*aisText = gameObject.GetComponent<Text>();

        aisText.text = "\n " + "Idmessage : " + ShipDynamicDataList.shipDynamic[0].idmessage
             + "\n " + "Idsession: " + ShipDynamicDataList.shipDynamic[0].idsession
             + "\n " + "Longitude: " + ShipDynamicDataList.shipDynamic[0].longitude
             + "\n " + "Latitude: " + ShipDynamicDataList.shipDynamic[0].latitude
             + "\n " + "Latitude: " + ShipDynamicDataList.shipDynamic[0].time_stamp_system
             +"\n " + "MMSI: " + ShipDynamicDataList.shipDynamic[0].MMSI;*/

        // AIS Data LAT AND LONG FOR SHIP[1]
        float r = 2;
        string lonString = ShipDynamicDataList.shipDynamic[2].longitude;
        float lonFloat = (float)double.Parse(lonString) * r;

       // lonFloat = r * Mathf.PI * lonFloat / 180;

        string latString = ShipDynamicDataList.shipDynamic[2].latitude;
        float latFloat = (float)double.Parse(latString) * r;

        //lonFloat = r * Mathf.PI * lonFloat / 180;

        transform.localPosition = new Vector3(lonFloat, 0, latFloat);

    



    }
}
