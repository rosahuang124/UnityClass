using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorDrawer : MonoBehaviour {

	public Vector3 vector;
	[Range(1000, 4000)]
	public float scale = 4000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDrawGizmos(){
		vector = transform.forward*scale;
		Gizmos.color = Color.yellow;
		Gizmos.DrawLine (transform.position, transform.position + vector);
	}
}
