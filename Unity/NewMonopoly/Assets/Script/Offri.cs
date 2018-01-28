using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Offri : MonoBehaviour {

    /*public Giocatore giocatore1;
    public Giocatore giocatore2;
    public Giocatore giocatore3;
    public Giocatore giocatore4;
    public Giocatore giocatore5;
    public Giocatore giocatore6;*/

    public GameObject Nonhaisoldi;
    public Button b;
    public Text Offerta1;
    public Text Offerta2;

    public GameObject bga;
    public GameObject bga1;

    public GameObject offri1;
    public GameObject accetta1;
    public GameObject controproposta1;
    public GameObject rifiuta1;

    // Use this for initialization
    void Start() {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    

    public void controllo()
    {
         
        if(int.Parse(Offerta1.text) > 999)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
        {
            Nonhaisoldi.active = true;
            b.gameObject.active = true;
        }
        //--------------------------------//
        else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 1"))
            {
            if (int.Parse(Offerta2.text) > 999)//prendo il saldo del player selezionato al posto di 999// CurrentPlayerID.Soldi; 
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
            }
        }
            else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 2"))
            {
            if (int.Parse(Offerta2.text) > 999)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
            }
        }
            else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 3"))
            {
            if (int.Parse(Offerta2.text) > 999)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
            }
        }
            else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 4"))
            {
            if (int.Parse(Offerta2.text) > 999)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
            }
        }
            else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 5"))
            {
            if (int.Parse(Offerta2.text) > 999)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
            }
        }
            else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 6"))
            {
            if (int.Parse(Offerta2.text) > 999)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
            }
        }
           else 
            offri();

        // if (int.Parse(GameObject.Find("Inserisci_Soldi2").GetComponent<Text>().text) > )

    }
    public void unload()
    {
        Nonhaisoldi.active = false;
        b.gameObject.active = false;
    }

    public void accetta()
    {

        int soldidaaggiungere = 0;
        int soldidarimuovere = 0;

        //COSE DA FARE QUANDO SI ACCETTA
        /*InputField inf1 = GameObject.Find("Inserisci_Soldi1").GetComponent<InputField>();
        InputField inf2 = GameObject.Find("Inserisci_Soldi2").GetComponent<InputField>();
        if (inf1.text != null)
            soldidarimuovere = int.Parse(inf1.text);
        if (inf2.text != null)
            soldidaaggiungere = int.Parse(inf2.text);*/

        if (Offerta1 != null)
            soldidarimuovere = int.Parse(Offerta1.text);
        if (Offerta2.text != null)
            soldidaaggiungere = int.Parse(Offerta2.text);

        
        //PROBLEMA Capire come prendere i parametri del giocatore, probabile mi serva la struttura dati del giocatore, che non è ancora stata creata
        int saldoPlayer1 = int.Parse(GameObject.Find("SOLDI1").GetComponent<Text>().text); //Prendo il saldo del giocatore corrente //state
        int saldoPlayer2 = 0;

        if (GameObject.Find("Player2").GetComponent<Text>().text.Equals ("Player 1"))
        {
             saldoPlayer2 = int.Parse(GameObject.Find("SOLDI2").GetComponent<Text>().text); //Prendo il saldo del giocatore selezionato //state
        }
        else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 2"))
        {
            saldoPlayer2 = int.Parse(GameObject.Find("SOLDI1").GetComponent<Text>().text); //Prendo il saldo del giocatore selezionato
        }
        else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 3"))
        {
            saldoPlayer2 = int.Parse(GameObject.Find("SOLDI1").GetComponent<Text>().text); //Prendo il saldo del giocatore selezionato
        }
        else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 4"))
        {
            saldoPlayer2 = int.Parse(GameObject.Find("SOLDI1").GetComponent<Text>().text); //Prendo il saldo del giocatore selezionato
        }
        else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 5"))
        {
            saldoPlayer2 = int.Parse(GameObject.Find("SOLDI1").GetComponent<Text>().text); //Prendo il saldo del giocatore selezionato
        }
        else if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 6"))
        {
            saldoPlayer2 = int.Parse(GameObject.Find("SOLDI1").GetComponent<Text>().text); //Prendo il saldo del giocatore selezionato
        }
        


        saldoPlayer1 = saldoPlayer1 + soldidaaggiungere - soldidarimuovere; //Se non ci sono offrte sui soldi somma e sottrae 0, quindi rimane invarito, modifico lo il paramentro nel palyer
        saldoPlayer2 = saldoPlayer2 + soldidaaggiungere - soldidarimuovere;
        GameObject.Find("SOLDI1").GetComponent<Text>().text = saldoPlayer1.ToString();
        GameObject.Find("SOLDI2").GetComponent<Text>().text = saldoPlayer2.ToString();

        SceneManager.LoadScene(2);
    }

    public void offri()
    {
        offri1.active = false;
        accetta1.active = true;
        controproposta1.active = true;
        rifiuta1.active = true;
        bga.active = false;
        bga1.active = true;
    }

    public void controproposta()
    {
        offri1.active = true;
        accetta1.active = false;
        controproposta1.active = false;
        rifiuta1.active = false;
        bga.active = false;
        bga1.active = true;
        bga.active = true;
        bga1.active = false;
    }

}
