using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitonklick : MonoBehaviour {

    public void Quit()
    {
        Debug.Log("Button Quit geklickt");

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit ();
        #endif
    }
}
