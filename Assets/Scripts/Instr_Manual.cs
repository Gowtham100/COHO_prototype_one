using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instr_Manual : MonoBehaviour {

	//public GameObject object3;
	//public GameObject object4;
	//public GameObject object6;

	public Transform target;
	public float speed;
	public bool rotate = false;
	public bool start = false;

	// Use this for initialization
	void Start () {
		//rotate = false;
		if (rotate) {
			transform.Rotate (0, 90, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//object 3 goes to x = 5
		//object 4 goes to x = 50
		//object 6 rotates to 0 degs, then moves x = 2, z = 3
		float step = speed * Time.deltaTime;

		//if (Input.GetKeyDown(KeyCode.A)){
		if (start) {
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		}
		//}

	}
}
