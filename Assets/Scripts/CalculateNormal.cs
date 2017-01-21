using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateNormal : MonoBehaviour {

    public GameObject normalObject;
    public Vector2 normal;

	// Use this for initialization
	void Start () {
        normal = transform.position - normalObject.transform.position;
        normal.Normalize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
