﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceltaPedina : MonoBehaviour {
	
    public int contatoregiocatori = 2;

    private void Start()
    {
        StateController.giocatoriSelezionati = 2;
    }

    public void numgiocatori()
    {
        contatoregiocatori = int.Parse(EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name);
        GameObject.Find("Numero").GetComponent<Text>().text = contatoregiocatori.ToString();
        StateController.giocatoriSelezionati = contatoregiocatori;
    }
}
