using System.Collections;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    //public for runtime testing 
    public float moveSpeed = 3.0f;

    //true or false if controller is touched or screen is touched 
    //public for testing purposes
    public bool moveForward;

    //head of the gvr emulator for transforming
    private Transform vrHead;

    //main gvr
    private GvrEditorEmulator gvrViewer;

    // Use this for initialization
    private void Start()
    {
        //allows the vrHead camera to be manipulated
        vrHead = Camera.main.transform;

        //sets the gvrViewer to the gvr emulator
        gvrViewer = transform.GetChild(0).GetComponent<GvrEditorEmulator>();
    }

    // Update is called once per frame
    private void Update()
    {
        //checks if screen is touched
        if (Input.GetButtonDown("Fire1"))
        {
            //sets moveForward to true and false
            moveForward = !moveForward;
        }

        //if moveForward is true
        if (moveForward)
        {

            //transform the vrHead to a forward dirtection
            Vector3 forward = vrHead.TransformDirection(Vector3.forward);

 
        }
        
    }
}
