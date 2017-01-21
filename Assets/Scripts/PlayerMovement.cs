using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float translateSpeed;
	public GameObject playerPointer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("right"))
			transform.Translate (translateSpeed*Time.deltaTime,0,0);

		if (Input.GetKey ("left")) 
			transform.Translate (-translateSpeed*Time.deltaTime,0,0);

		if(Input.GetKey("up")) 
			transform.Translate (0,translateSpeed*Time.deltaTime,0);

		if(Input.GetKey("down")) 
			transform.Translate (0,-translateSpeed*Time.deltaTime,0);
	}
}
