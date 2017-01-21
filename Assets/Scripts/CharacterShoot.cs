using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShoot : MonoBehaviour {
    
    public GameObject bulletObject;
    public GameObject bulletPool;
    private List<GameObject> poolBullets;

    public float timeToShoot;
    private float shootTimer;

	// Use this for initialization
	void Start () {
        poolBullets = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if(GameData.gameRunning) {
            shootTimer -= Time.deltaTime;
            if(shootTimer <= 0)
            {
                GameObject bullet = getBullet();
                bullet.transform.parent = bulletPool.transform;
                bullet.transform.position = transform.position;
                bullet.transform.eulerAngles = transform.eulerAngles;
                bullet.GetComponent<BulletCollision>().ResetHits();
                bullet.active = true;
                shootTimer += timeToShoot;
            }
        }
    }

    GameObject getBullet()
    {
        foreach(GameObject bullet in poolBullets)
        {
            if(!bullet.active)
            {
                return bullet;
            }
        }

        GameObject newBullet = GameObject.Instantiate(bulletObject);
        poolBullets.Add(newBullet);
        return newBullet;
    }

}
