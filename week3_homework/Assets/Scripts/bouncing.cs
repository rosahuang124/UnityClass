using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncing : MonoBehaviour {

	public GameObject target;
	public AudioSource sfx;
	public Vector3 velocity;
	private Vector3 acceleration;


	// Use this for initialization
	void Start () {
		this.transform.position = new Vector3 (0, -93f, 0);
		velocity = new Vector3 (Random.Range (-2f, 2f), Random.Range (-2f, 2f), Random.Range (-2f, 2f));
		acceleration = new Vector3 (0, 1f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += velocity;
		Vector3 originPoint = new Vector3 (0,0,0);
		//Vector3 pointOnSphere = new Vector3 (this.transform.position.x + this.transform.localScale.x, this.transform.position.y + this.transform.localScale.y, this.transform.position.z + this.transform.localScale.z);
		float distance = Vector3.Distance (originPoint, this.transform.position);
		boundCheck (distance, target.GetComponent<ballBound>().ballSize);
		print ("Distance to originPoint: " + distance);
		//boundCheck (this.transform.position, target.GetComponent<ballBound>().ballSize, this.transform.localScale);
		accelerationMovement ();
	}

	void boundCheck(float distance, float radius){

		if (distance > 0 && distance >= radius) {
			velocity *= -1f;
			sfx.Play ();
		}

		if (distance <= 0 && distance <= - radius) {
			velocity *= -1f;
			sfx.Play ();
		}
			
	}



	void accelerationMovement(){
		velocity = velocity + acceleration * Time.deltaTime;
	}
}
