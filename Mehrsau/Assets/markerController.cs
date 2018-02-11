using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class markerController : MonoBehaviour {
	public Sprite smallDist;
	public Sprite medDist;
	public Sprite BigDist;

	private SpriteRenderer render;

	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void mark(float dist){
		print (dist);
		if (dist <= 4) {
			print ("klein");
			render.sprite = smallDist;
		}
		else if (dist <= 7) {
			render.sprite = medDist;
		}

		else if (dist > 7) {
			render.sprite = BigDist;
		}
	}
}
