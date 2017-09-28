using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBound : MonoBehaviour {

	public float ballSize;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDrawGizmos() {
		Gizmos.DrawWireSphere (transform.position, ballSize);
	}
}
