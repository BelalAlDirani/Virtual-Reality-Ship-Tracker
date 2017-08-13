/*using System;
using System.Collections;
using System.Collections.Generic;
using Boomlagoon.JSON;
using NUnit.Framework;
using UnityEngine;

public class GetAPIData : MonoBehaviour {

    string Url;
    Ship newShip;
    
	// Use this for initialization
	void Start () {

        Url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/ais_voyages_dynamic.php?passwd=dJHSRzhqu4&session=314";
        newShip = new Ship();
        getData();

        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    class Ship
    {
        public int idmessage { get; set; }
        public int idsession  { get; set; } 
        public string time_stamp_system { get; set; } 
        public string NMEA_string { get; set; } 
        public int processed { get; set; } 
        public int MMSI { get; set; } 
        public int navigation_status { get; set; } 
        public int ROT { get; set; } 
        public double SOG { get; set; } 
        public int position_accuracy { get; set; } 
        public double longitude { get; set; } 
        public double latitude { get; set; } 
        public int COG { get; set; } 
        public int true_heading { get; set; } 
        public int maneuver_indicator { get; set; } 
        public int RAIM_flag { get; set; } 
        public int diagnostic_information { get; set; } 
        public int time_stamp_seconds_only { get; set; }  
    }
                    
    void getData()
    {
        WWW www = new WWW(Url);

        StartCoroutine("GetDataEnumerator", Url);

    }

    List ships;
    IEnumerator GetDataEnumerator(WWW www)
    {

        yield return www;
        if(www.error != null)
        {

            
            /*string serviceData = www.text;

            Debug.Log(serviceData);

            JSONArray json = JSONArray.Parse(www.text);
            if (json == null)
            {
                Debug.Log("No data converted");
            }
            else if (json.Length > 0)
            {

                ships = new List();

                for (int i = 0; i < json.Length; i++)
                {
                    newShip.idmessage = Convert.ToInt32(json[i].Obj["idmessage"].Number);
                    newShip.idsession = Convert.ToInt32(json[i].Obj["idsession"].Number);
                    newShip.time_stamp_system = json[i].Obj["time_stamp_system"].Str;
                    newShip.NMEA_string = json[i].Obj["NMEA_string"].Str;
                    newShip.processed = Convert.ToInt32(json[i].Obj["processed"].Number);
                    newShip.MMSI = Convert.ToInt32(json[i].Obj["MMSI"].Number);
                    newShip.navigation_status = Convert.ToInt32(json[i].Obj["navigation_status"].Number);
                    newShip.ROT = Convert.ToInt32(json[i].Obj["ROT"].Number);
                    newShip.SOG = Convert.ToDouble(json[i].Obj["SOG"].Number);
                    newShip.position_accuracy = Convert.ToInt32(json[i].Obj["position_accuracy"].Number);
                    newShip.longitude = Convert.ToDouble(json[i].Obj["longitude"].Number);
                    newShip.latitude = Convert.ToDouble(json[i].Obj["latitude"].Number);
                    newShip.COG = Convert.ToInt32(json[i].Obj["COG"].Number);
                    newShip.true_heading = Convert.ToInt32(json[i].Obj["true_heading"].Number);
                    newShip.maneuver_indicator = Convert.ToInt32(json[i].Obj["maneuver_indicator"].Number);
                    newShip.RAIM_flag = Convert.ToInt32(json[i].Obj["RAIM_flag"].Number);
                    newShip.diagnostic_information = Convert.ToInt32(json[i].Obj["diagnostic_information"].Number);
                    newShip.time_stamp_seconds_only = Convert.ToInt32(json[i].Obj["time_stamp_seconds_only"].Number);

                }

            }

        }
        else
        {
            Debug.Log(www.error);
        }

        int lol = newShip.idmessage;

        Debug.Log(lol);
    }

}*/
