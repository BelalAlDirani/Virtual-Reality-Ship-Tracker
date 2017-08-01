using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class jsonReader : MonoBehaviour {

    string path;
    string jsonstring;
    private Text aisText;

    public object ShipDynamicDataList { get; private set; }

    void Start()
    {
       

        path = Application.streamingAssetsPath + "/shipStatic.json";
        jsonstring = File.ReadAllText(path);
        shipStaticDataList ShipStaticDataList = new shipStaticDataList();
        JsonUtility.FromJsonOverwrite (jsonstring, ShipStaticDataList);
        

        path = Application.streamingAssetsPath + "/shipDynamic.json";
        jsonstring = File.ReadAllText(path);
        shipDynamicDataList ShipDynamicDataList = new shipDynamicDataList();
        JsonUtility.FromJsonOverwrite(jsonstring, ShipDynamicDataList);
        Debug.Log("Ship 0 LON: " + ShipDynamicDataList.shipDynamic[0].longitude);
         Debug.Log("Ship 0 LAT: " + ShipDynamicDataList.shipDynamic[0].latitude);





        // AIS TEXT CANVAS FOR SHIP[0]

        /*aisText = gameObject.GetComponent<Text>();

        aisText.text = "\n " + "Idmessage : " + ShipDynamicDataList.shipDynamic[0].idmessage
             + "\n " + "Idsession: " + ShipDynamicDataList.shipDynamic[0].idsession
             + "\n " + "Longitude: " + ShipDynamicDataList.shipDynamic[0].longitude
             + "\n " + "Latitude: " + ShipDynamicDataList.shipDynamic[0].latitude
             + "\n " + "Latitude: " + ShipDynamicDataList.shipDynamic[0].time_stamp_system
             +"\n " + "MMSI: " + ShipDynamicDataList.shipDynamic[0].MMSI;*/





        // AIS Data LAT AND LONG FOR SHIP[0]
        float r = 2;
        string lonString = ShipDynamicDataList.shipDynamic[0].longitude;
        float lonFloat = (float)double.Parse(lonString);

        //lonFloat = r * Mathf.PI * lonFloat / 180;

        //lonFloat = (int)((250 / 360.0) * (180 + lonFloat));

        

        string latString = ShipDynamicDataList.shipDynamic[0].latitude;
        float latFloat = (float)double.Parse(latString);

        //lonFloat = r * Mathf.PI * lonFloat / 180;

        //latFloat = (int)((250 / 180.0) * (90 - latFloat));

         float LAT = latFloat * Mathf.PI / 180;
         float LON = lonFloat * Mathf.PI / 180;

         float x = -r * Mathf.Cos(LAT) * Mathf.Cos(LON);
         float y = r * Mathf.Sin(LAT);
         float z = -r * Mathf.Cos(LAT) * Mathf.Sin(LON);


         transform.localPosition = new Vector3(x, y, z);

      
        

    }

    void Update()
    {
      

        
    }

}


[System.Serializable]
public class shipStaticData
{
    public string idmessage;
    public string idsession;
    public string time_stamp_system;
    public string NMEA_string;
    public string processed;
    public string MMSI;
    public string AIS_version;
    public string IMO_number;
    public string call_sign;
    public string name;
    public string type_of_ship_and_cargo;
    public string bow_to_position_unit;
    public string stern_to_position_unit;
    public string port_to_position_unit;
    public string starboard_to_position_unit;
    public string type_of_position_fixing_divice;
    public string ETA;
    public string destination;
    public string last_static_draught;
    public string DTE;
}

[System.Serializable]
public class shipDynamicData
{
    public string idmessage;
    public string idsession;
    public string time_stamp_system;
    public string NMEA_string;
    public string processed;
    public string MMSI;
    public string navigation_status;
    public string ROT;
    public string SOG;
    public string position_accuracy;
    public string longitude;
    public string latitude;
    public string COG;
    public string trueheading;
    public string maneuver_indicator;
    public string RAIM_flag;
    public string diagnostic_information;
    public string time_stamp_seconds_only;
}

[System.Serializable]
public class shipStaticDataList
{

    public List<shipStaticData> shipStatic;
}

[System.Serializable]
public class shipDynamicDataList
{

    public List<shipDynamicData> shipDynamic;
}


