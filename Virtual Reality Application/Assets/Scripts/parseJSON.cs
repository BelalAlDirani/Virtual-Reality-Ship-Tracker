using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System;

public class parseJSON : MonoBehaviour {

	/*public string idmessage;
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
	public string true_heading;
	public string maneuver_indicator;
	public string RAIM_flag;
	public string diagnostic_information;
	public string time_stamp_seconds_only;*/


	//public string title;
	//public string id;
	//public ArrayList but_title;
	//public ArrayList but_image;

	public ArrayList but_idmessage;
	public ArrayList but_idsession;
	public ArrayList but_time_stamp_system;
	public ArrayList but_NMEA_string;
	public ArrayList but_processed; 
	public ArrayList but_MMSI;
	public ArrayList but_navigation_status;
	public ArrayList but_ROT;
	public ArrayList but_SOG;
	public ArrayList but_position_accuracy;
	public ArrayList but_longitude;
	public ArrayList but_latitude;
	public ArrayList but_COG;
	public ArrayList but_true_heading;
	public ArrayList but_maneuver_indicator;
	public ArrayList but_RAIM_flag;
	public ArrayList but_diagnostic_information;
	public ArrayList but_time_stamp_seconds_only;

}
public class JSON_D : MonoBehaviour
{
  

    // Sample JSON for the following script has attached.
    IEnumerator Start()
	{
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/ais_voyages_dynamic.php?passwd=dJHSRzhqu4&session=314";
		//string url = " URL of the JSON to be Decode";
		WWW www = new WWW(url);
		yield return www;
		if (www.error == null)
		{
			Processjson(www.text);

        }
		else
		{
			Debug.Log("ERROR: " + www.error);
		}



        JSONObject json = new JSONObject(www.text);
        Debug.Log(json.GetField("time_stamp_system").str);



    }
    private void Processjson(string jsonString)
	{
		JsonData jsonvale = JsonMapper.ToObject(jsonString);
		parseJSON parsejson;
		parsejson = new parseJSON();


		//parsejson.title = jsonvale["title"].ToString();
		//parsejson.id = jsonvale["ID"].ToString();

		//parsejson.but_title = new ArrayList ();
		//parsejson.but_image = new ArrayList ();
		
		parsejson.but_idmessage = new ArrayList ();
		parsejson.but_idsession = new ArrayList ();
		parsejson.but_time_stamp_system = new ArrayList ();
		parsejson.but_NMEA_string = new ArrayList ();
		parsejson.but_processed = new ArrayList ();
		parsejson.but_MMSI = new ArrayList ();
		parsejson.but_navigation_status = new ArrayList ();
		parsejson.but_ROT = new ArrayList ();
		parsejson.but_SOG = new ArrayList ();
		parsejson.but_position_accuracy = new ArrayList ();
		parsejson.but_longitude = new ArrayList ();
		parsejson.but_latitude = new ArrayList ();
		parsejson.but_COG = new ArrayList ();
		parsejson.but_true_heading = new ArrayList ();
		parsejson.but_maneuver_indicator = new ArrayList ();
		parsejson.but_RAIM_flag = new ArrayList ();
		parsejson.but_diagnostic_information = new ArrayList ();
		parsejson.but_time_stamp_seconds_only = new ArrayList ();


		/*for(int i = 0; i<jsonvale["buttons"].Count; i++)
		{
			parsejson.but_title.Add(jsonvale["buttons"][i]["title"].ToString());
			parsejson.but_image.Add(jsonvale["buttons"][i]["image"].ToString());
		} */

		for(int i = 0; i <jsonvale.Count; ++i)
		{
            parsejson.but_idmessage.Add(jsonvale[i]["idmessage"].ToString());
			parsejson.but_idsession.Add(jsonvale[i]["idsession"].ToString());
			parsejson.but_time_stamp_system.Add(jsonvale[i]["time_stamp_system"].ToString());
			parsejson.but_NMEA_string.Add(jsonvale[i]["NMEA_string"].ToString());
			parsejson.but_processed.Add(jsonvale[i]["processed"].ToString());
			parsejson.but_MMSI.Add(jsonvale[i]["MMSI"].ToString());
			parsejson.but_navigation_status.Add(jsonvale[i]["navigation_status"].ToString());
			parsejson.but_ROT.Add(jsonvale[i]["ROT"].ToString());
			parsejson.but_SOG.Add(jsonvale[i]["SOG"].ToString());
			parsejson.but_position_accuracy.Add(jsonvale[i]["position_accuracy"].ToString());
			parsejson.but_longitude.Add(jsonvale[i]["longitude"].ToString());
			parsejson.but_latitude.Add(jsonvale[i]["latitude"].ToString());
			parsejson.but_COG.Add(jsonvale[i]["COG"].ToString());
			parsejson.but_true_heading.Add(jsonvale[i]["true_heading"].ToString());
			parsejson.but_maneuver_indicator.Add(jsonvale[i]["maneuver_indicator"].ToString());
			parsejson.but_RAIM_flag.Add(jsonvale[i]["RAIM_flag"].ToString());
			parsejson.but_diagnostic_information.Add(jsonvale[i]["diagnostic_information"].ToString());
			parsejson.but_time_stamp_seconds_only.Add(jsonvale[i]["time_stamp_seconds_only"].ToString());
		}


       

    }
}