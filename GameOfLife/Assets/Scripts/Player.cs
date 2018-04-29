using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {

        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {

        float movement = Input.GetAxis("Vertical");
        float strafe   = Input.GetAxis("Horizontal");
        movement *= Time.deltaTime;
        strafe *= Time.deltaTime;

        transform.Translate(strafe * speed, 0, movement * speed);
		
	}
}
