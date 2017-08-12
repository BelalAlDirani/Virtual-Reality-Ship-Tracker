using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PerspecDev; 
using System;

public class PlaylistMenu : MonoBehaviour {


	public int toolbarInt = 0;
	//public string[] toolbarStrings = {}; 
	List<String> listPlaylist = new List<String>();

	//playlists 
	public class Playlists : APIBuddy.WebResponseData {
		public PlaylistData[] entries;
	}

	public class PlaylistData : APIBuddy.WebResponseData {

		public string idplaylist; 
		public string name; 

	}

	//private string _outputText = "";


	private void OnGUI()
	{
		toolbarInt = GUI.Toolbar(new Rect(50, 50, 250, 60), toolbarInt, listPlaylist);
	}


	/*private void OnGUI()
	{
		RequestPlaylistData (); 


		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Playlist Data")) {
			RequestPlaylistData ();
		}

		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText);
	}*/

	/*private void OnGUI() {
		if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), "Request Playlist Data")) {
			RequestPlaylistData ();
		}

		GUI.TextArea(new Rect(20.0f, 100.0f, 500.0f, 400.0f), _outputText);
	}*/

//private void OnGUI(){
	private void RequestPlaylistData() {
		string url = "http://homepage.cs.latrobe.edu.au/16maritime01/api/v5/playlists.php?passwd=dJHSRzhqu4";
		APIBuddy.GetInstance().SendGetRequest<Playlists> (url, 20.0f, (bool success, string errorMessage, int statusCode, object responseObject) => {
			if (success) {

				Playlists playlists = (Playlists)responseObject; 

			//for(int i = 0; i < Playlists.Length; ++i )
			//{
			//}	

			foreach (PlaylistData entry in playlists.entries) {

				//Array.add(toolbarStrings, entry.name);
				//toolbarStrings.Add(entry.name);
				//toolbarStrings[toolbarInt++] = entry.name; //might not work 
				listPlaylist.Add(entry.name);
				++toolbarInt;

				//if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), entry.name)) {
				//	DoThis();
				//}


				/*private void OnGUI ()
				{

					if (GUI.Button (new Rect (20.0f, 20.0f, 200.0f, 50.0f), entry.name)) {
					DoThis();
				}

				}*/
			}


				/*_outputText = "";

				foreach (PlaylistData entry in playlists.entries) {
					_outputText += "===== " + entry.idplaylist + " =====";
					_outputText += "\n" + entry.name ;
					_outputText += "\n\n";
				}*/

			} //else {
				//_outputText = "Could not pull the data you wanted " + errorMessage;
			//}
		});

	}






//private void OnGUI()
//{
//	GUI.Box (Rect (10, 10, 100, 90), "Playlist Menu");

	//one GUI for each name 
	//number of buttons
	//names in each button
//}





private void DoThis()
	{
		Debug.Log("works");

	}

	// Use this for initialization
	void Start () {
		//RequestPlaylistData (); 
		//OnGUI();
	}
	
}
