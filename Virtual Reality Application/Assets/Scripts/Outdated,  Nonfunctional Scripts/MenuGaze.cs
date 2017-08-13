using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGaze : MonoBehaviour {

    public float sightLength = 100f;
    public GameObject selectedObj;
    public float hoverForwardDistance = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        RaycastHit seen;
        Ray rayDirection = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(rayDirection, out seen, sightLength))
        {
            if(seen.collider.tag == "Button")
            {
                if(selectedObj != null && selectedObj != seen.transform.gameObject)
                {
                    GameObject hitObject = seen.transform.gameObject;
                    MoveMenuButton(hitObject);
                }
                selectedObj = seen.transform.gameObject;
            }
        }
		
	}

    private void MoveMenuButton(GameObject hitObject)
    {
        Vector3 newZ = hitObject.transform.position;
        newZ.z -= hoverForwardDistance;
        selectedObj.transform.position = newZ;

        newZ.z += hoverForwardDistance * 2;
        hitObject.transform.position = newZ;
    }
}
