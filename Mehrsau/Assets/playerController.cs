using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed = 0.2f;
	public GameObject GUI;


	void Start () {
		
	}


	
        
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			float dist = Vector2.Distance (new Vector2(transform.position.x,transform.position.y), new Vector2( GameObject.FindGameObjectWithTag ("GuineaPig").transform.position.x,GameObject.FindGameObjectWithTag ("GuineaPig").transform.position.y));
			GUI.GetComponent<markerController> ().mark (dist);

		}

	}

	void FixedUpdate(){
		Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
		GetComponent<Rigidbody2D> ().velocity = targetVelocity * speed;
	}


	
}
