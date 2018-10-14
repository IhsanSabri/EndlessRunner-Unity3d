using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Text highScoreText;

	// Use this for initialization
	void Start () {
        highScoreText.text = "Highscore : " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();
	}

    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }
}
