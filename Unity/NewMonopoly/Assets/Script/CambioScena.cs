﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScena : MonoBehaviour {

    public void Adattivo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Caricascena(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void ESCI()
    {
        Application.Quit();
    }

}
