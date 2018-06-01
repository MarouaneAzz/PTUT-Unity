using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    public static bool pauseB = false;

    public GameObject MenuPause;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseB)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
	}

    public void pause()
    {
        MenuPause.SetActive(true);
        Time.timeScale = 0f;
        pauseB = true;
    }

    public void resume()
    {
        MenuPause.SetActive(false);
        Time.timeScale = 1f;
        pauseB = false;
    }

    public void quitter()
    {
        Application.Quit();
    }
}
