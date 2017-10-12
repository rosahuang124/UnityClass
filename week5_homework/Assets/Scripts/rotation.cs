using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
	
	[Range(0,1)]
	public float step = 1;


	private Quaternion startRotation;

	public enum RotationType
	{
		rotateByStep,
		rotateAdditive,
		rotateAxisAngle,
		quaternionByStep,
		quaternionAdditiveToLastRot,
		quaternionAdditiveToStartRot
	}

	public RotationType rotationType;

	// Use this for initialization
	void Start () {
		
		startRotation = transform.rotation;
		
	}
	
	// Update is called once per frame
	void Update () {

		switch (rotationType) {
		case RotationType.rotateByStep:
			transform.Rotate(0, Time.deltaTime*60, 0);
			break;
		case RotationType.rotateAdditive:
			transform.Rotate(0, Time.time, 0);
			break;
		case RotationType.rotateAxisAngle:
			transform.Rotate(transform.up, step);
			break;
		case RotationType.quaternionByStep:
			transform.rotation = Quaternion.AngleAxis(step, transform.up) * transform.rotation;
			break;
		case RotationType.quaternionAdditiveToLastRot:
			transform.rotation = Quaternion.AngleAxis(Time.time, transform.up) * transform.rotation;
			break;
		case RotationType.quaternionAdditiveToStartRot:
			transform.rotation = Quaternion.AngleAxis(Time.time, transform.up) * startRotation;
			break;
		default:
			break;
		}
		
	}
}
