using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScripts : MonoBehaviour {

    public void Histoire()
    {
        SceneManager.LoadScene("MenuActe");
    }

    public void Quit()
    {
        Application.Quit();
    }


}
