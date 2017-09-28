using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VectorDrawer : MonoBehaviour {


	public Vector3 direction1 = new Vector3(10, 10, 10);
	public Vector3 direction2 = new Vector3(-10, 10, 10);
	public Vector3 direction3 = new Vector3(10, 10, -10);
	public Vector3 direction4 = new Vector3(-10, 10, -10);
	public Vector3 stem = new Vector3(0, 10, 0);

	[Range(0,10)]
	public float scale = 1;
	public Color color;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnDrawGizmos(){
		DrawVector(transform.position, direction1.normalized*scale, color);
		DrawVector(transform.position, direction2.normalized*scale, color);
		DrawVector(transform.position, direction3.normalized*scale, color);
		DrawVector(transform.position, direction4.normalized*scale, color);
		DrawVector(transform.position, stem.normalized*scale, color);

		DrawFlower(transform.position, direction1.normalized * scale);
		DrawFlower(transform.position, direction2.normalized * scale);
		DrawFlower(transform.position, direction3.normalized * scale);
		DrawFlower(transform.position, direction4.normalized * scale);
		DrawFlower(transform.position, stem.normalized * scale);
	}

	void DrawVector(Vector3 start, Vector3 direction, Color color){
		Gizmos.color = color;
		Gizmos.DrawLine (start, start + direction);
	}

	void DrawFlower(Vector3 start, Vector3 direction1){
		Gizmos.DrawIcon (direction1, "flower.png", true);
	}

}
