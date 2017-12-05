using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class player : MonoBehaviour {
    [SerializeField]
    Rigidbody Body;
    void Awake()
    {
        if (!Body) Body = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Input.GetAxis("Horizontal"));
        Debug.Log(Input.GetAxis("Vertical"));
	}
    void FixedUpdate()
    {
        Body.velocity= new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
    }
}
