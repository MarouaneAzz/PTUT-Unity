using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class actionMenu : MonoBehaviour {

    public void retourMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
