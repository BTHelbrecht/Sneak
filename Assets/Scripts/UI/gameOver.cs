using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {

    public GameObject gameOverScreen;
    private float time;

	// Use this for initialization
	void Start () {
        time = Time.fixedDeltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        if(time == 0)
        {
            gameOverScreen.SetActive(true);
        }
	}
}
