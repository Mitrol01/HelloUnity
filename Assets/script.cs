using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
    [SerializeField]
    //GameObject cube;
    GameObject amo;
    int Nbinstance = 3;
    GameObject instance;
     void Awake()
    {
       //instance = Instantiate(cube, transform.position,transform.rotation);
       // instance.name = "enemi";
       // instance.transform.parent = transform;
    }

    // Use this for initialization
    void Start () {
        //Debug.Log("coucou");
        //Debug.LogWarning("gros coucou");
        //Debug.LogError("badass");
        for (int i = 0; i < Nbinstance; i++)
        {
            Vector3 newPos = new Vector3(transform.position.x + i, transform.position.y, transform.position.z);
            Instantiate(amo, newPos, transform.rotation);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //pour gerer la physique du jeu 
     void FixedUpdate()
    {
        
    }
}
