using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intr_Manager : MonoBehaviour {
	
	public List<GameObject> objects = new List<GameObject>();
	private Instr_Manual instrM;
	public GameObject[] g;

	// Use this for initialization
	void Start () {

		g = GameObject.FindGameObjectsWithTag ("attachmentObject"); 	

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//int i = 0;
		//while( i < objects.Count) {
		int i = 0;
			instrM = g [i].GetComponent<Instr_Manual> ();
			if (Input.GetKeyDown (KeyCode.Space)) {
				instrM.start = true;
			}


		if (g [i].transform.position == instrM.target.position) {
			i++;
			instrM = g [i].GetComponent<Instr_Manual> ();
			if (Input.GetKeyDown (KeyCode.Space)) {
				instrM.start = true;
			}
		}

		if (g [i].transform.position == instrM.target.position) {
			i++;
			instrM = g [i].GetComponent<Instr_Manual> ();
			if (Input.GetKeyDown (KeyCode.Space)) {
				instrM.start = true;
			}
		}
	}
}
