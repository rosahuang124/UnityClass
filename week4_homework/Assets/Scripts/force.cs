using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour {

	public Vector3 forceVector;
	public vectorDrawer forceSource;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		forceVector = Vector3.forward;
		forceVector = forceSource.vector;
		rb.GetComponent<Rigidbody> ();
		rb.AddForce (forceVector); 
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
