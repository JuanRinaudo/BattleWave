using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float translateSpeed;
    public int player = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(player == 1) {
		    if (Input.GetKey ("right"))
			    transform.Translate (translateSpeed*Time.deltaTime,0,0);

		    if (Input.GetKey ("left")) 
			    transform.Translate (-translateSpeed*Time.deltaTime,0,0);

		    if(Input.GetKey("up")) 
			    transform.Translate (0,translateSpeed*Time.deltaTime,0);

		    if(Input.GetKey("down")) 
			    transform.Translate (0,-translateSpeed*Time.deltaTime,0);
        } else
        {
            if (Input.GetKey(KeyCode.D))
                transform.Translate(translateSpeed * Time.deltaTime, 0, 0);

            if (Input.GetKey(KeyCode.A))
                transform.Translate(-translateSpeed * Time.deltaTime, 0, 0);

            if (Input.GetKey(KeyCode.W))
                transform.Translate(0, translateSpeed * Time.deltaTime, 0);

            if (Input.GetKey(KeyCode.S))
                transform.Translate(0, -translateSpeed * Time.deltaTime, 0);
        }
    }
}
