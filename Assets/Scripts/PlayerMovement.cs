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
	void Update ()
    {
        float speed = translateSpeed * Time.deltaTime;
        if (player == 1)
        {
            //Debug.Log("JOYSTICK1: " + new Vector2(Input.GetAxis("Joystick1AxisX"), Input.GetAxis("Joystick1AxisY")));
            transform.Translate(Input.GetAxis("Joystick1AxisX") * speed, Input.GetAxis("Joystick1AxisY") * speed, 0);

            if (Input.GetKey("right"))
                transform.Translate(translateSpeed * Time.deltaTime, 0, 0);

            if (Input.GetKey("left"))
                transform.Translate(-translateSpeed * Time.deltaTime, 0, 0);

            if (Input.GetKey("up"))
                transform.Translate(0, translateSpeed * Time.deltaTime, 0);

            if (Input.GetKey("down"))
                transform.Translate(0, -translateSpeed * Time.deltaTime, 0);
    } else
        {
            //Debug.Log("JOYSTICK2: " + new Vector2(Input.GetAxis("Joystick2AxisX"), Input.GetAxis("Joystick2AxisY")));
            transform.Translate(Input.GetAxis("Joystick2AxisX") * speed, Input.GetAxis("Joystick2AxisY") * speed, 0);

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
