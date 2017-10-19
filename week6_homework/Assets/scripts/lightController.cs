using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightController : MonoBehaviour {

	//private Light spotLight;


	void Start () {
		transform.Rotate (0, Time.time,0);
	}
	
	// Update is called once per frame
	void Update () {
		int t1 = Random.Range(30, 60);
		int t2 = Random.Range(30, 60);

		transform.Rotate (Time.deltaTime * t1, Time.deltaTime * t2, Time.deltaTime * t2 ); 
	}
}
