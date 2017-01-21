using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position);
        Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Vector2.Angle(
            new Vector2(1, 0),
            new Vector2(worldMousePos.x - transform.position.x, worldMousePos.y - transform.position.y));

        if (worldMousePos.y < transform.position.y)
        {
            angle += 180;
        }

        Debug.Log(angle);
        if ((angle > 0 && angle < 45) || (angle > 180 && angle < 225))
        {
            Debug.Log("Right");
        }
        if(angle > 45 && angle < 135)
        {
            Debug.Log("Top");
        }
        if((angle > 135 && angle < 180) || (angle > 315 && angle < 360))
        {
            Debug.Log("Left");
        }
        if(angle < 315 && angle > 235)
        {
            Debug.Log("Bottom");
        }
	}
}
