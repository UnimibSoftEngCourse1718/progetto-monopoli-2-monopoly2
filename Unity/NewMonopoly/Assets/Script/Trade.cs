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
    public Text player1;
    public Text Player2;

    public StateController sc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void trade()
    {
        TRATTATIVA.active = true;/*
        if (sc.CurrentPlayerId.Equals("P1"))
        {
            player1.text = "Player 1";
        }
        else if (sc.CurrentPlayerId.Equals("P2"))
        {
            player1.text = "Player 2";
        }
        else if (sc.CurrentPlayerId.Equals("P3"))
        {
            player1.text = "Player 3";
        }
        else if (sc.CurrentPlayerId.Equals("P4"))
        {
            player1.text = "Player 4";
        }
        else if (sc.CurrentPlayerId.Equals("P5"))
        {
            player1.text = "Player 5";
        }
        else if (sc.CurrentPlayerId.Equals("P6"))
        {
            player1.text = "Player 6";
        }*/
        
        player1.text = "PLAYER ATTIVO"; //state controller prendo il nome del giocatore corrente
        //GameObject.Find("Player1").GetComponent<Text>().text = "PLAYER ATTIVO"; //state controller prendo il nome del giocatore corrente
        
        if(EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa1"))
        {
            Player2.text = "Player 1";
            //GameObject.Find("Player2").GetComponent<Text>().text = "Player 1";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa2"))
        {
            Player2.text = "Player 2";
            //GameObject.Find("Player2").GetComponent<Text>().text = "Player 2";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa3"))
        {
            Player2.text = "Player 3";
            //GameObject.Find("Player2").GetComponent<Text>().text = "Player 3";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa4"))
        {
            Player2.text = "Player 4";
            //GameObject.Find("Player2").GetComponent<Text>().text = "Player 4";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa5"))
        {
            Player2.text = "Player 5";
            //GameObject.Find("Player2").GetComponent<Text>().text = "Player 5";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa6"))
        {
            Player2.text = "Player 6";
            //GameObject.Find("Player2").GetComponent<Text>().text = "Player 6";
        }


    }
    
}
