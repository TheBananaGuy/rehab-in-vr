using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    public bool onGround;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        Physics.gravity = new Vector3(0, -1.0F, 0);
        onGround = true;
        rb = GetComponent<Rigidbody>();
        // Starting in 2 seconds.
        // function will be launched every second
        InvokeRepeating("Jumping", 1f, 3.0f);
    }

	void Update () {
	}

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }

    void Jumping()
    {
        if (onGround)
        {
            rb.velocity = new Vector3(0.1f, 1.5f, 0f);
            onGround = false;
        }
    }
}
