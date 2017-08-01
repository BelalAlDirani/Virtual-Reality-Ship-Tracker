using System.Collections;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float moveSpeed = 3.0f;

    public bool moveForward;

    private Transform vrHead;

    private GvrEditorEmulator gvrViewer;

    // Use this for initialization
    private void Start()
    {
        vrHead = Camera.main.transform;

        gvrViewer = transform.GetChild(0).GetComponent<GvrEditorEmulator>();
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            moveForward = !moveForward;
        }

        if (moveForward)
        {


            Vector3 forward = vrHead.TransformDirection(Vector3.forward);

 
        }
        
    }
}
