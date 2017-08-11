using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PerspecDev; 

public class loadAllAPIData : MonoBehaviour {


	//playlists 
	public class Playlists : APIBuddy.WebResponseData {
		public PlaylistData[] entries;
	}

	public class PlaylistData : APIBuddy.WebResponseData {

		public string idplaylist; 
		public string name; 

	}

	private string _outputText = "";

	//example of how to test - create a GUI and action for when the button is clicked
	/*private void OnGUI() {
		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Playlist Data")) {
			RequestPlaylistData ();
		}

		//text field for the outputted text
		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText);
	}*/

	private void RequestPlaylistData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/playlists.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Playlists> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {

				Playlists playlists = (Playlists)responseObject; 
				//loop for all the playlist data which will be outputted to the text area
				/*_outputText = "";

				foreach (PlaylistData entry in playlists.entries) {
					_outputText += "===== " + entry.idplaylist + " =====";
					_outputText += "\n" + entry.name ;
					_outputText += "\n\n";
				}*/


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



	private void RequestPlaylistDataData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/playlists_data.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Playlist_Data> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Playlist_Data playlist_Data = (Playlist_Data)responseObject; 
			} else {
				_outputText3 = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}


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


	private void RequestScenarioData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/scenarios.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Scenario> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Scenario scenario = (Scenario)responseObject; 
			} 
			else {
				_outputText4 = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}

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


	private void RequestSessionData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/sessions.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Session> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Session session = (Session)responseObject; 
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

	private void RequestSourceData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/sources.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Source> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {
				Source source = (Source)responseObject; 
			} else {
				_outputText6 = "Could not pull the data you wanted " + errorMessage;
			}
		});

	}
		


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


	private void RequestStaticData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/ais_voyages_static.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Static> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {

				Static statics = (Static)responseObject; 

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



	private void RequestDynamicData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/ais_voyages_dynamic.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Dynamic> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {

				Dynamic dynamic = (Dynamic)responseObject; 

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
		RequestScenarioData();
		RequestSessionData();
		RequestSourceData();
		RequestStaticData();
		RequestDynamicData();

	}
		

	void Start () {
		RequestPlaylistData (); 
	}
}

