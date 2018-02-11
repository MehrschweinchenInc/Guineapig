using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;		//Allows us to use Lists.
using UnityEngine.UI;					//Allows us to use UI.




public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;
	public BoardManager boardScript;

	private int level = 1;

	void Awake()
	{
		if (instance==null)
		{
			instance = this;
		}else if (instance!=this)
		{
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);

		boardScript = GetComponent<BoardManager> ();
		InitGame ();
	}

	void InitGame()
	{
		boardScript.SetupScene (level);
	}

	void Update()
	{
	}
}