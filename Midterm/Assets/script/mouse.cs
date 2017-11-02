using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {

	public Transform Target;
	public float speedToCatchTarget = 1;


	Vector3 StartPos;
	Vector3 EndPos;

	public int minDist = 20; 


	void Start () {

		//StartPos = transform.position;
//		EndPos = Target.position;

	}

	void Update () {	
		transform.LookAt (Target);

		if (Vector3.Distance (transform.position, Target.position) >= minDist) {
			transform.position = Vector3.Lerp(transform.position, Target.position, Time.deltaTime  );
		}
	
	}
}
