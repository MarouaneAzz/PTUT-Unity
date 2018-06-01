using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class actionRetourChap : MonoBehaviour {

    public void retour()
    {
        SceneManager.LoadScene("MenuActe");
    }
}
