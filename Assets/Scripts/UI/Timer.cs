using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float startTime;
    private Text uiText;
    public GameObject gameOverScreen;
    public GameObject player;

	// Use this for initialization
	void Start () {
        uiText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        startTime -= Time.fixedDeltaTime;

        uiText.text = "" + Mathf.Round(startTime);

        if(startTime <= 0)
        {
            gameOverScreen.SetActive(true);
            startTime = 0;
            Destroy(player.gameObject);
        }
	}
}
