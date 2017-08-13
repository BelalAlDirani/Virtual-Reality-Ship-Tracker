using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PerspecDev; 

public class TF4 : MonoBehaviour {


	//playlists 
	public class Playlists : APIBuddy.WebResponseData {
		public PlaylistData[] entries;
	}

	public class PlaylistData : APIBuddy.WebResponseData {

		public string idplaylist; 
		public string name; 

	}

	private string _outputText = "";

	/*private void OnGUI() {
		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Playlist Data")) {
			RequestPlaylistData ();
		}

		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText);
	}*/

	private void RequestPlaylistData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/playlists.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Playlists> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Debug.Log("Works");

				Playlists playlists = (Playlists)responseObject; 

				/*_outputText = "";

				foreach (PlaylistData entry in playlists.entries) {
					_outputText += "===== " + entry.idplaylist + " =====";
					_outputText += "\n" + entry.name ;
					_outputText += "\n\n";
				}*/


				Debug.Log(responseObject);

			} else {
				_outputText = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}


	//**********************************************************************
	//playlist_data
	public class Playlist_Data : APIBuddy.WebResponseData {
		public Data_Playlist[] entries;
	}

	public class Data_Playlist : APIBuddy.WebResponseData {

		public string idplaylist;
		public string playlist_name;
		public string idscenario;
		public string idsession;
		public string scenario_name;
		public string area;
		public string time_end;
		public string time_start;
		public string idplaylist_item;
		public string index;
		public string idnext;
		public string idprev;

	}

	private string _outputText3 = "";

	/*private void OnGUI() {
		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Playlist Data's Data")) {
			RequestPlaylistDataData ();
		}

		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText3);
	}*/

	private void RequestPlaylistDataData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/playlists_data.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Playlist_Data> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Debug.Log("Works");

				Playlist_Data playlist_Data = (Playlist_Data)responseObject; 

				/*_outputText3 = "";

				foreach (Data_Playlist entry in playlist_Data.entries) {
					_outputText3 += "===== " + entry.idplaylist + " =====";
					_outputText3 += "\n" + entry.playlist_name;
					_outputText3 += "\n" + entry.idscenario;
					_outputText3 += "\n" + entry.idsession;
					_outputText3 += "\n" + entry.scenario_name;
					_outputText3 += "\n" + entry.area;
					_outputText3 += "\n" + entry.time_end;
					_outputText3 += "\n" + entry.time_start;
					_outputText3 += "\n" + entry.idplaylist_item;
					_outputText3 += "\n" + entry.index;
					_outputText3 += "\n" + entry.idnext;
					_outputText3 += "\n" + entry.idprev;
					_outputText3 += "\n\n";
				}*/


				Debug.Log(responseObject);

			} else {
				_outputText3 = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}


	//***************************************************************
	//doesn't work **************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//scenarios
	public class Scenario : APIBuddy.WebResponseData {
		public ScenarioData[] entries;
	}

	public class ScenarioData : APIBuddy.WebResponseData {

		public string idscenario;
		public string idsession;
		public string time_start;
		public string time_end;
		public string area;
		public string lat1;
		public string long1;
		public string lat2;
		public string long2;
		public string name;


	}

	private string _outputText4 = "";

	/*private void OnGUI() {
		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Scenario Data")) {
			RequestScenarioData ();
		}

		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText4);
	}*/

	private void RequestScenarioData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/scenarios.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Scenario> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Debug.Log("Works");

				Scenario scenario = (Scenario)responseObject; 

				/*_outputText4 = "";

				foreach (ScenarioData entry in scenario.entries) {
					_outputText4 += "===== " + entry.idscenario + " =====";
					_outputText4 += "\n" + entry.idsession;
					_outputText4 += "\n" + entry.time_start;
					_outputText4 += "\n" + entry.time_end;
					_outputText4 += "\n" + entry.area;
					_outputText4 += "\n" + entry.lat1;
					_outputText4 += "\n" + entry.long1;
					_outputText4 += "\n" + entry.lat2;
					_outputText4 += "\n" + entry.long2;
					_outputText4 += "\n" + entry.name;
					_outputText4 += "\n\n";
				}*/


				Debug.Log(responseObject);

			} 
			else {
				_outputText4 = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}

	//***************************************************************
	//doesn't work **************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//sessions
	public class Session : APIBuddy.WebResponseData {
		public SessionData[] entries;
	}

	public class SessionData : APIBuddy.WebResponseData {

		public string idsession;
		public string ownMMSI;
		public string idsource;


	}

	private string _outputText5 = "";

	/*private void OnGUI() {
		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Session Data")) {
			RequestSessionData ();
		}

		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText5);
	}*/

	private void RequestSessionData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/sessions.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Session> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Debug.Log("Works");

				Session session = (Session)responseObject; 

				/*_outputText5 = "";

				foreach (SessionData entry in session.entries) {
					_outputText5 += "===== " + entry.idsession + " =====";
					_outputText5 += "\n" + entry.ownMMSI;
					_outputText5 += "\n" + entry.idsource;
					_outputText5 += "\n\n";
				}*/


				Debug.Log(responseObject);

			} else {
				_outputText5 = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}


	//***************************************************************
	//sources
	public class Source : APIBuddy.WebResponseData {
		public SourceData[] entries;
	}

	public class SourceData : APIBuddy.WebResponseData {

		public string idsource;
		public string name;

	}

	private string _outputText6 = "";

	/*private void OnGUI() {
		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Source Data")) {
			RequestSourceData ();
		}

		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText6);
	}*/

	private void RequestSourceData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/sources.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Source> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Debug.Log("Works");

				Source source = (Source)responseObject; 

				/*_outputText6 = "";

				foreach (SourceData entry in source.entries) {
					_outputText6 += "===== " + entry.idsource + " =====";
					_outputText6 += "\n" + entry.name;
					_outputText6 += "\n\n";
				}*/


				Debug.Log(responseObject);

			} else {
				_outputText6 = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}
		


	//****************************************************************************
	//doesn't work **************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//***************************************************************
	//static
	public class Static : APIBuddy.WebResponseData {
		public StaticData[] entries;
	}

	public class StaticData : APIBuddy.WebResponseData {

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
		public string type_of_position_fixing_device;
		public string ETA;
		public string destination;
		public string last_static_draught;
		public string DTE;

	}

	private string _outputText1 = "";

	/*private void OnGUI() {
		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Static Data")) {
			RequestStaticData ();
		}

		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText1);
	}*/

	private void RequestStaticData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/ais_voyages_static.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Static> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Debug.Log("Works");

				Static statics = (Static)responseObject; 

				/*_outputText1 = "";

				foreach (StaticData entry in statics.entries) {
					_outputText1 += "===== " + entry.idmessage + " =====";
					_outputText1 += "\n" + entry.idsession;
					_outputText1 += "\n" + entry.time_stamp_system;
					_outputText1 += "\n" + entry.NMEA_string;
					_outputText1 += "\n" + entry.processed;
					_outputText1 += "\n" + entry.MMSI;
					_outputText1 += "\n" + entry.AIS_version;
					_outputText1 += "\n" + entry.IMO_number;
					_outputText1 += "\n" + entry.call_sign;
					_outputText1 += "\n" + entry.name;
					_outputText1 += "\n" + entry.type_of_ship_and_cargo;
					_outputText1 += "\n" + entry.bow_to_position_unit;
					_outputText1 += "\n" + entry.stern_to_position_unit;
					_outputText1 += "\n" + entry.port_to_position_unit;
					_outputText1 += "\n" + entry.starboard_to_position_unit;
					_outputText1 += "\n" + entry.type_of_position_fixing_device;
					_outputText1 += "\n" + entry.ETA;
					_outputText1 += "\n" + entry.destination;
					_outputText1 += "\n" + entry.last_static_draught;
					_outputText1 += "\n" + entry.DTE;
					_outputText1 += "\n\n";
				}*/


				Debug.Log(responseObject);

			} else {
				_outputText1 = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}
		




	//dynamic data 
	public class Dynamic : APIBuddy.WebResponseData {
		public DynamicData[] entries;
	}

	public class DynamicData : APIBuddy.WebResponseData {

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
		public string true_heading;
		public string maneuver_indicator;
		public string RAIM_flag;
		public string diagnostic_information;
		public string time_stamp_seconds_only;

	}

	private string _outputText2 = "";

	/*private void OnGUI() {
		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Dynamic Data")) {
			RequestDynamicData ();
		}

		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText2);
	}*/

	private void RequestDynamicData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/ais_voyages_dynamic.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Dynamic> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Debug.Log("Works");

				Dynamic dynamic = (Dynamic)responseObject; 

				/*_outputText2 = "";

				foreach (DynamicData entry in dynamic.entries) {
					_outputText2 += "===== " + entry.idmessage + " =====";
					_outputText2 += "\n" + entry.idsession;
					_outputText2 += "\n" + entry.time_stamp_system;
					_outputText2 += "\n" + entry.NMEA_string;
					_outputText2 += "\n" + entry.processed;
					_outputText2 += "\n" + entry.MMSI;
					_outputText2 += "\n" + entry.navigation_status;
					_outputText2 += "\n" + entry.ROT;
					_outputText2 += "\n" + entry.SOG;
					_outputText2 += "\n" + entry.position_accuracy;
					_outputText2 += "\n" + entry.longitude;
					_outputText2 += "\n" + entry.latitude;
					_outputText2 += "\n" + entry.COG;
					_outputText2 += "\n" + entry.true_heading;
					_outputText2 += "\n" + entry.maneuver_indicator;
					_outputText2 += "\n" + entry.RAIM_flag;
					_outputText2 += "\n" + entry.diagnostic_information;
					_outputText2 += "\n" + entry.time_stamp_seconds_only;
					_outputText2 += "\n\n";
				}*/


				Debug.Log(responseObject);

			} 
			else {
				_outputText2 = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}

	private void RequestAllData()
	{
		RequestPlaylistData();
		RequestPlaylistDataData();
		//RequestScenarioData();
		//RequestSessionData();
		RequestSourceData();
		//RequestStaticData();
		RequestDynamicData();

	}

}

