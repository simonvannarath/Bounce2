using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetoid : MonoBehaviour {

    Rigidbody rigi;
    Transform sun;

	// Use this for initialization
	void Start ()
    {
        rigi = GetComponent<Rigidbody>();
        sun = GameObject.Find("Sun").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rigi.AddForce(sun.position - transform.position);

	}
}
