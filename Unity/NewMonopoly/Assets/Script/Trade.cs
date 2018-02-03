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

    public giocatore p1;
    public giocatore p2;
    public giocatore p3;
    public giocatore p4;
    public giocatore p5;
    public giocatore p6;

    public void trade()
    {
        TRATTATIVA.SetActive(true);

        if (p1.attivo == true)
        {
            player1.text = "Player 1";
        }
        else if (p2.attivo == true)
        {
            player1.text = "Player 2";
        }
        else if (p3.attivo == true)
        {
            player1.text = "Player 3";
        }
        else if (p4.attivo == true)
        {
            player1.text = "Player 4";
        }
        else if (p5.attivo == true)
        {
            player1.text = "Player 5";
        }
        else if (p6.attivo == true)
        {
            player1.text = "Player 6";
        }

        if(EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa1"))
        {
            Player2.text = "Player 1";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa2"))
        {
            Player2.text = "Player 2";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa3"))
        {
            Player2.text = "Player 3";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa4"))
        {
            Player2.text = "Player 4";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa5"))
        {
            Player2.text = "Player 5";
        }
        else if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().name.Equals("Trattativa6"))
        {
            Player2.text = "Player 6";
        }
    }
}
