﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class actionMenuActe : MonoBehaviour {

    public void Retour()
    {
        SceneManager.LoadScene("Menu");
    }
}
