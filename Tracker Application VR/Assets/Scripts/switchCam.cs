using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCam : MonoBehaviour
{
    //array of the cameras
    public Camera[] cameras;
    private int currentCameraIndex;

    //used for trigger delay
    private float nextSwap = 5.0F;
    public static float realTime = 0.0F;

    // Use this for initialization
    void Start()
    {
        currentCameraIndex = 0;

        //Turn all cameras off, except the first default one
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }

        //If any cameras were added to the controller, enable the first one
        if (cameras.Length > 0)
        {
            cameras[0].gameObject.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
        //Realtime is concatonated with Time
        realTime = realTime + Time.deltaTime;

        //If the c button is pressed, switch to the next camera
        //Set the camera at the current index to inactive, and set the next one in the array to active
        //When we reach the end of the camera array, move back to the beginning or the array.
        if (Input.GetButton("Fire1") && realTime > nextSwap)
        {
            currentCameraIndex++;
            Debug.Log("Screen has been touched. Switching to the next camera");
            if (currentCameraIndex < cameras.Length)
            {
                //camera at [index -1] is disabled
                cameras[currentCameraIndex - 1].gameObject.SetActive(false);
                //while [index] is enabled
                cameras[currentCameraIndex].gameObject.SetActive(true);

                //Time gets reset
                realTime = 0.0F;
            }
            else
            {
                cameras[currentCameraIndex - 1].gameObject.SetActive(false);
                currentCameraIndex = 0;
                cameras[currentCameraIndex].gameObject.SetActive(true);

               
                realTime = 0.0F;
            }

           
            realTime = 0.0F;
        }

       
    }

    /*gui for displaying the time stamp of when tthe trainee can swap to another ship (every 5 seconds)
     * and Time Stamp for ship path
    
    void OnGUI()
    {
        String Time = "Time Stamp for next ship switch";

        //Float to String conversion
        String timeString = String.Format("{0:0,0.0000000}", realTime);

        //TextAreas
        Time = GUI.TextArea(new Rect(10, 10, 225, 25), Time, 200);
        timeString = GUI.TextArea(new Rect(10, 50, 125, 25), timeString, 200);
    }*/
}
