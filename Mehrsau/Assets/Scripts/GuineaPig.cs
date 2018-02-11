using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuineaPig : MovingObject {

	private Animator animator;
	private Transform target;
	private bool skipMove;

	// Use this for initialization
	protected override void Start () {
		animator = GetComponent<Animator> ();
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected override void AttemptMove <T> ( int xDir, int yDir)
	{
		if (skipMove)
		{
			skipMove = false;
			return;
		}
		base.AttemptMove <T>(xDir,yDir);
	}
	//TODO Guinea pig  woanders  hinbewegen wenn zu oft geraschelt wurde
	public void MoveGuineaPig()
	{
		return;
	}

	//dummy für behinderung beim bewegen
	protected override void OnCantMove<T> (T component)
	{
		return;
	}
}
