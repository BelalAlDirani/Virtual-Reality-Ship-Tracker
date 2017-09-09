using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
public class ShipDatabase : MonoBehaviour {

    private List<Static> databse = new List<Static>();

    private JsonData StaticData;

    void Start()
    {

        StaticData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Static.json"));
        ConstructStaticDatabase();

        Debug.Log(databse[0].Idmessage);

    }

    void ConstructStaticDatabase()
    {
        for(int i = 0; i < StaticData.Count; i++)
        {
            databse.Add(new Static(StaticData[i]["idmessage"].ToString(), StaticData[i]["idsession"].ToString(),
                StaticData[i]["MMSI"].ToString()));
        }
    }

	
}

public class Static
{
    public string Idmessage { get; set; }
    public string Idsession { get; set; }
    public string MMSI { get; set; }

    public Static(string Idmessage, string Idsession, string MMSI)
    {
        this.Idmessage = Idmessage;
        this.Idsession = Idsession;
        this.MMSI = MMSI;
    }

}
