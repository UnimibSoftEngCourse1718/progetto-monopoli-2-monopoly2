using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.EventSystems;

public class Trade : MonoBehaviour {

    public GameObject TRATTATIVA;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void trade()
    {
        TRATTATIVA.active = true;
        GameObject.Find("Player1").GetComponent<Text>().text = "PLAYER ATTIVO"; //state controller prendo il nome del giocatore corrente
        
        if(EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trade1"))
        {
            GameObject.Find("Player2").GetComponent<Text>().text = "Player 1";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trade2"))
        {
            GameObject.Find("Player2").GetComponent<Text>().text = "Player 2";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trade3"))
        {
            GameObject.Find("Player2").GetComponent<Text>().text = "Player 3";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trade4"))
        {
            GameObject.Find("Player2").GetComponent<Text>().text = "Player 4";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trade5"))
        {
            GameObject.Find("Player2").GetComponent<Text>().text = "Player 5";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trade6"))
        {
            GameObject.Find("Player2").GetComponent<Text>().text = "Player 6";
        }

    }
    
}
