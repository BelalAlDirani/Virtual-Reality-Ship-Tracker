using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class Ship1 : MonoBehaviour
{

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
        Debug.Log("Ship 1 LON: " + ShipDynamicDataList.shipDynamic[1].longitude);
        Debug.Log("Ship 1 LAT: " + ShipDynamicDataList.shipDynamic[1].latitude);

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
        string lonString = ShipDynamicDataList.shipDynamic[1].longitude;
        float lonFloat = (float)double.Parse(lonString);

        //lonFloat = r * Mathf.PI * lonFloat / 180;

        string latString = ShipDynamicDataList.shipDynamic[1].latitude;
        float latFloat = (float)double.Parse(latString);

        // latFloat = r * Mathf.PI * latFloat / 180;

         float LAT = latFloat * Mathf.PI / 180;
         float LON = lonFloat * Mathf.PI / 180;

         float x = -r * Mathf.Cos(LAT) * Mathf.Cos(LON);
         float y = r * Mathf.Sin(LAT);
         float z = -r * Mathf.Cos(LAT) * Mathf.Sin(LON);


       

        transform.localPosition = new Vector3(x, y, z);





    }

}




