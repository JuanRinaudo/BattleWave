using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullets2" || collision.gameObject.tag == "Bullets1")
        {
            BulletCollision bulletCollision = collision.gameObject.GetComponent<BulletCollision>();
            if(bulletCollision.hitCounter == 0) {
                if (gameObject.tag == "Player1" && collision.gameObject.tag == "Bullets1") { return; }
                if (gameObject.tag == "Player2" && collision.gameObject.tag == "Bullets2") { return; }
            }
            Destroy(gameObject);
        }
    }
}
