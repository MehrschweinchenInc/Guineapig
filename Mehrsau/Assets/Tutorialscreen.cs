using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tutorialscreen : MonoBehaviour {

    public string sceneToLoad;

    void Start()
    {

    }

    void Update()
    {

    }

    public void LoadLevel()
    {
        //ausgewähltes Level starten
        SceneManager.LoadScene(sceneToLoad);
    }

}
