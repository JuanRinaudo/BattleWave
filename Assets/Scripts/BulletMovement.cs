using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float movementSpeed = 5;
    public float outOfBoundsDistance = 25;
    public Vector2 movementDelta;

	// Use this for initialization
	void Start () {
        OnEnable();
	}

    void Awake()
    {

    }

    private void OnEnable()
    {
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(transform.position);
        //Debug.Log(worldMousePos);
        movementDelta = new Vector2(worldMousePos.x, worldMousePos.y) - new Vector2(transform.position.x, transform.position.y);
        //Debug.Log(movementDelta);
        movementDelta.Normalize();
    }

    // Update is called once per frame
    void Update () {
        transform.position = transform.position + new Vector3(movementDelta.x, movementDelta.y, 0) * movementSpeed * Time.deltaTime;

        if(Vector3.Distance(transform.position, new Vector3(0, 0, 0)) > outOfBoundsDistance)
        {
            gameObject.SetActive(false);
        }
	}

}
