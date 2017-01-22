using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectionUI : MonoBehaviour {

	private int ind; //0,1,2//

	public int indMultiplier;

	// Use this for initialization
	void Start () {
		ind = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("down") && ind<2){
			ind++;
			transform.Translate(0,-indMultiplier, 0);
		}
		if (Input.GetKeyDown("up") && ind > 0){
			ind--;
			transform.Translate(0,indMultiplier, 0);
			Debug.Log(ind.ToString());
		}

		if (Input.GetKeyDown("space") && ind==0){
			SceneManager.LoadScene ("MainState");
		}

		if (Input.GetKeyDown("space") && ind==1){
			Debug.Log ("Creditos");
		}

		if (Input.GetKeyDown("space") && ind==2){
			Application.Quit ();
			Debug.Log ("Quit");
		}
			

	}
}
