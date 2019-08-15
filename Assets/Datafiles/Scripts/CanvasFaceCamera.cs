using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFaceCamera : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		//Get direction = (pos of canvas - pos of camera)
		Vector3 direction = transform.position - Camera.main.transform.position;
		//Set forward direction of the canvas
		transform.forward = direction;
	}
}
