using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {

	public Transform Target;
	public float speedToCatchTarget = 0.1f;


	Vector3 StartPos;
	Vector3 EndPos;

	public int maxDist = 6;
	public int minDist = 2; 


	void Start () {

		StartPos = transform.position;
		EndPos = Target.position;

	}

	void Update () {	

		if (Vector3.Distance (transform.position, Target.position) >= minDist) {
			transform.LookAt (Target);
			transform.position += transform.forward*speedToCatchTarget*Time.deltaTime;

		} 


	}
}
