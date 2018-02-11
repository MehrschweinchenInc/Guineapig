using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapGenerator : MonoBehaviour {

	public int rows = 5;
	public int colloms = 5;

	public GameObject outaWall;
	public GameObject floor;
	public GameObject stone;
	public GameObject mehrsau;

	private int spriteSize = 0;

	private int stoneNumber;
	

	// Use this for initialization 
	void Start () {
		stoneNumber = 3;

		spriteSize = (int)(floor.GetComponent<SpriteRenderer> ().bounds.size.x);

		//Floor
		for (int x = 0; x <= rows; x++) {
			for (int y = 0; y <= colloms; y++) {
				Instantiate (floor, new Vector3 (x * spriteSize, y * spriteSize, 0),Quaternion.identity);
			}
		}

		//Walls

		for (int x = -1; x <= rows+1; x++) {
			Instantiate (outaWall, new Vector3 (x * spriteSize, -spriteSize, 0),Quaternion.identity);
			Instantiate (outaWall, new Vector3 (x * spriteSize, colloms * spriteSize + spriteSize, 0),Quaternion.identity);
		}

		for (int y = -1; y <= colloms + 1; y++) {
			Instantiate (outaWall, new Vector3 (-spriteSize, y * spriteSize, 0),Quaternion.identity);
			Instantiate (outaWall, new Vector3 (spriteSize * rows + spriteSize, y * spriteSize, 0),Quaternion.identity);
		}

		//Stones
		for (int x = 0; x <= stoneNumber; x++) {
			Instantiate (stone, new Vector3 (Random.Range (0, rows) * spriteSize, Random.Range (0, colloms) * spriteSize, 0), Quaternion.identity);
		}

		//Mehrsau

		Instantiate (mehrsau,new Vector3 (Random.Range (0, rows) * spriteSize, Random.Range (0, colloms) * spriteSize, 0), Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
