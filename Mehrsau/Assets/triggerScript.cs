using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnTriggerStay2D (Collider2D other){
		if (other.tag == "GuineaPig") {
			if (Input.GetKey (KeyCode.Space)) {
				GameObject.Find ("Gewonnen").GetComponent<SpriteRenderer> ().enabled = true;
                AudioSource audio = other.gameObject.GetComponent<AudioSource>();
                audio.Play ();

			}
		}
	}
}
