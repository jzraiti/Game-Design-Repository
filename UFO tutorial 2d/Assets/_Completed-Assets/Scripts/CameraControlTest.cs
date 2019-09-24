using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlTest : MonoBehaviour
{
	/*
	public GameObject follow;

	private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - follow.transform.position;
    }

    // LateUpdate is called once per frame AFTER all items have been modified
    
    void LateUpdate()
    {
        transform.position = follow.transform.position + offset; 
    }
    
    void LateUpdate () 
    {
		transform.position = new Vector3(follow.transform.position.x, follow.transform.position.y, -10);
    }
	*/

	public Transform player = null;
 	public float cameraHeight = 20.0f;
 	private Transform cam = null;
 
 
 	public void Start()
 	{
     	cam = transform;
 	}
 	public void Update()
 	{
     	Vector3 pos = player.position;
     	pos.z = cameraHeight;
     	cam.position = pos;
	}

}
