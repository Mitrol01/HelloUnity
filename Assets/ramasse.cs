using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramasse : MonoBehaviour
{
    [SerializeField]
    LayerMask layer;
    GameObject myPick;
    Rigidbody myPickBody;
    [SerializeField]
    GameObject feedback;
    // Use this for initialization
    void Start()
    {
        feedback.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (myPick)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                Debug.Log("should drop");

                myPick.transform.parent = null;
                myPick = null;
                if (myPickBody)
                {
                    myPickBody.isKinematic = false;
                    myPickBody = null;

                }
            }
        }
    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5f, layer))
        {
            if (!myPick)
            {
                feedback.SetActive(true);
            }
            else
            {
                feedback.SetActive(false);
            }
            if (Input.GetButtonDown("Fire1"))
            {
                myPick = hit.transform.gameObject;
                myPick.transform.parent = transform;

                if (myPick.GetComponent<Rigidbody>())
                {
                    myPickBody = myPick.GetComponent<Rigidbody>();
                    myPickBody.isKinematic = true;
                }

            }
        }
        else
        {
            feedback.SetActive(false);
        }
    }
}