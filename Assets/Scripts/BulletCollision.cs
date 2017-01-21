using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

    BulletMovement bulletMovement;
    public int collisionHits = 5;
    [HideInInspector]
    public int hitCounter = 0;

	// Use this for initialization
	void Start () {
        bulletMovement = GetComponent<BulletMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetHits()
    {
        hitCounter = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Walls") {
            CalculateNormal calculateNormal = collision.gameObject.GetComponent<CalculateNormal>();
            bulletMovement.movementDelta = (2 * Vector2.Dot(bulletMovement.movementDelta, calculateNormal.normal) * calculateNormal.normal) - bulletMovement.movementDelta;

            hitCounter++;
            if (hitCounter > collisionHits)
            {
                gameObject.SetActive(false);
            }
        }
        if (this.gameObject.tag == "Bullets1")
        {
            if (collision.gameObject.tag == "Shield2")
            {
                CalculateNormal calculateNormal = collision.gameObject.GetComponent<CalculateNormal>();
                bulletMovement.movementDelta = (2 * Vector2.Dot(bulletMovement.movementDelta, calculateNormal.normal) * calculateNormal.normal) - bulletMovement.movementDelta;

                hitCounter++;
                if (hitCounter > collisionHits)
                {
                    gameObject.SetActive(false);
                }
            }
            if ((collision.gameObject.tag == "Shield1") && (hitCounter != 0))
            {
                CalculateNormal calculateNormal = collision.gameObject.GetComponent<CalculateNormal>();
                bulletMovement.movementDelta = (2 * Vector2.Dot(bulletMovement.movementDelta, calculateNormal.normal) * calculateNormal.normal) - bulletMovement.movementDelta;

                hitCounter++;
                if (hitCounter > collisionHits)
                {
                    gameObject.SetActive(false);
                }
            }
        }
        if (this.gameObject.tag == "Bullets2")
        {
            if (collision.gameObject.tag == "Shield1")
            {
                CalculateNormal calculateNormal = collision.gameObject.GetComponent<CalculateNormal>();
                bulletMovement.movementDelta = (2 * Vector2.Dot(bulletMovement.movementDelta, calculateNormal.normal) * calculateNormal.normal) - bulletMovement.movementDelta;

                hitCounter++;
                if (hitCounter > collisionHits)
                {
                    gameObject.SetActive(false);
                }
            }
            if ((collision.gameObject.tag == "Shield2") && (hitCounter != 0))
            {
                CalculateNormal calculateNormal = collision.gameObject.GetComponent<CalculateNormal>();
                bulletMovement.movementDelta = (2 * Vector2.Dot(bulletMovement.movementDelta, calculateNormal.normal) * calculateNormal.normal) - bulletMovement.movementDelta;

                hitCounter++;
                if (hitCounter > collisionHits)
                {
                    gameObject.SetActive(false);
                }
            }
        }

    }
}
