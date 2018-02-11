using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MovingObject {

	public int pointsPerWin = 100;
	public int rustleCount = 10;
	public float restartLevelDelay = 1f;

	private Animator animator;
	private int score=0;

	// Use this for initialization
	protected override void Start () {
		animator = GetComponent<Animator> ();

		score = GameManager.instance.highscore;
		base.Start ();
	}

	private void OnDisable()
	{
		GameManager.instance.highscore = score;
	}

	// Update is called once per frame
	void Update () {
		if (!GameManager.instance.playersTurn)
		{
			return;
		}

		int horizontal = 0;
		int vertical = 0;
		bool useKey = false;

		horizontal = (int)Input.GetAxisRaw ("Horizontal");
		vertical = (int)Input.GetAxisRaw ("Vertical");
		if (Input.GetKey (KeyCode.Space))
			useKey = true;

		if (horizontal != 0)
		{
			vertical = 0;
			useKey = false;
		} else if (vertical != 0)
		{
			horizontal = 0;
			useKey = false;
		} else
		{
			horizontal = 0;
			vertical = 0;
		}
		if (horizontal!=0||vertical!=0)
		{
			AttemptMove <GuineaPig>(horizontal, vertical);
		}
		//TODO bewegungsanimations trigger Implementieren und Raschel funktion + Trigger

	}

	protected override void AttemptMove<T> (int xDir, int yDir)
	{
		base.AttemptMove<T> (xDir, yDir);
		RaycastHit2D hit;
		//CheckIfGameOver ();
		GameManager.instance.playersTurn = false;
	}

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "GuineaPig")
		{
			score += pointsPerWin;
			Invoke ("Restart", restartLevelDelay);
			enabled = false;
		}
			
	}

	private void CheckIfGameOver()
	{
		if (rustleCount <= 0)
			GameManager.instance.GameOver ();
	}

	protected override void OnCantMove<T> (T component)
	{
		return;
	}

	private void Restart()
	{
		SceneManager.LoadScene (0);
	}
}