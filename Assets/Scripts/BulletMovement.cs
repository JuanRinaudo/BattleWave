using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float movementSpeed = 5;
    Vector3 movementDelta;

	// Use this for initialization
	void Start () {

	}

    void Awake()
    {

    }

    private void OnEnable()
    {
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        movementDelta = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
            new Vector2(worldMousePos.x, worldMousePos.y), 0.01f);
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(movementDelta * movementSpeed * Time.deltaTime);
	}

}
