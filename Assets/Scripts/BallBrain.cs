using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBrain : MonoBehaviour {

    Rigidbody rigi;
	// Use this for initialization
	void Start ()
    {
        rigi = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Bounce")
        print("Hello!");
        rigi.velocity = (transform.position - collision.contacts[0].point);
    }
}
