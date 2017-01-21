using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour {
    public float cooldownTime;
    public float shieldTime;
    private float delayTime=0;
    private bool shieldActivated=false;
    public GameObject shieldObject;
    public int player = 0;
    private bool shieldCooldown=false;

    // Use this for initialization
    void Start () {
        shieldObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (!shieldCooldown)
        {
            if (player == 1)
            {
                if ((Input.GetKey(KeyCode.Comma)) && (!shieldActivated))
                {
                    shieldObject.SetActive(true);
                    shieldActivated = true;
                    delayTime = shieldTime;
                }
            }
            if (player == 2)
            {
                if ((Input.GetKey(KeyCode.V)) && (!shieldActivated))
                {
                    shieldObject.SetActive(true);
                    shieldActivated = true;
                    delayTime = shieldTime;
                }
            }
            if (shieldActivated)
            {
                delayTime -= Time.deltaTime;
                if (delayTime <= 0)
                {
                    shieldActivated = false;
                    shieldObject.SetActive(false);
                    shieldCooldown = true;
                    delayTime = cooldownTime; 
                }
            }
        }
        else
        {
            delayTime -= Time.deltaTime;
            if (delayTime <= 0)
            {
                shieldCooldown = false;
                delayTime = cooldownTime;
            }
        }
    }
}
