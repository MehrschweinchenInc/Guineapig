using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D (Collider2D other){
		if (other.tag == "GuineaPig") {
			if (Input.GetKey (KeyCode.Space)) {
				GameObject.Find ("Gewonnen").GetComponent<SpriteRenderer> ().enabled = true;
			}
		}
	}
}
