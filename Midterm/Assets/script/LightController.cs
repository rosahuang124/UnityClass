using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    private Light light;

    [Range(0, 1)]
    public float t = 0.01f;

    public float increment;

    public Transform lightTarget;
    [Tooltip("How fast light tries to reach target - passed into 't' variable. Smaller values are slower")]
    public float speedToCatchTarget = 0.1f;

    Quaternion startRotation;
    Quaternion endRotation;

	// Use this for initialization
	void Start () {
        
        light = GetComponent<Light>();
        t = 0;

        startRotation = transform.rotation;
        endRotation = Quaternion.LookRotation(lightTarget.forward, Vector3.up);

		transform.position = new Vector3 (lightTarget.position.x, transform.position.y, lightTarget.position.z);


	}
	
	// Update is called once per frame
	void Update () {
 

        t += increment;

        if (t <= 0 || t>= 1)
        {
            increment *= -1;        
        }

        Debug.Log("T is " + t);

        //light.color = Color.Lerp(colorA, colorB, t);

        Vector3 lookVector = lightTarget.position - transform.position;
        //Debug.DrawRay(transform.position, lookVector, Color.red, 1);
       
        endRotation = Quaternion.LookRotation(lookVector, Vector3.up);
        
		transform.rotation = Quaternion.Slerp (transform.rotation, endRotation, speedToCatchTarget);
        
		float angleFromLightToTarget = Quaternion.Angle(transform.rotation, endRotation);
        angleFromLightToTarget *= 0.1f;
       

		transform.position = new Vector3 (lightTarget.position.x, transform.position.y, lightTarget.position.z);


    }
}
