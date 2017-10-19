using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightColor : MonoBehaviour {
	public Color colorA;
	public Color colorB;

	private Light spotLight;

	public float increment;

	[Range(0,1)]
	public float t;

	// Use this for initialization
	void Start () {
		spotLight = GetComponent<Light> ();
		t = 0;
	}
	
	// Update is called once per frame
	void Update () {
		t += increment;

		if (t <= 0 || t >= 1) {
			increment *= -1f;
		}
		spotLight.color = Color.Lerp (colorA, colorB, t);
	}
}
