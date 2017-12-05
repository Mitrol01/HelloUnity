using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class jump : MonoBehaviour
{



    [SerializeField]
    Rigidbody body;

    float jumpForce = 750f;

    [SerializeField]
    float CoolDown = 1f;
    float buffer = 0f;

    void Awake()
    {
        if (!body) body = GetComponent<Rigidbody>();

    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (buffer >= CoolDown)
        {
            if (Input.GetButtonDown("Jump"))
            {
                body.AddForce(transform.up * jumpForce);
                buffer = 0f;
            }

        }
        else buffer += Time.deltaTime;

    }
}

