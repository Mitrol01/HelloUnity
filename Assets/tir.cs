using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tir : MonoBehaviour {
    [SerializeField]
    GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, Camera.main.transform.position, Camera.main.transform.rotation);
        }
	}
}
