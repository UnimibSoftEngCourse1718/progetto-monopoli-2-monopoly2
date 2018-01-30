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

    public Text text1;
    public Text text2;

    public Text player2;

    public giocatore p1;
    public giocatore p2;
    public giocatore p3;
    public giocatore p4;
    public giocatore p5;
    public giocatore p6;

  

    // Use this for initialization
    void Start() {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    

    public void controllo()
    {
        /*Offerta1.text = "0";
        Offerta2.text = "0";*/ //Inizializzare per evitare errore

        ////NOTA BISOGNA INSERIRE SEMPRE UN VALORE IN DENARO, SE NON SI VUOLE OFFRIRE NULLA SI METTE 0
        bool attiva = true;

        if (p1.attivo == true)
        {
            if (int.Parse(Offerta1.text) > p1.soldi)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {

                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
        }
        else if (p2.attivo == true)
        {
            if (int.Parse(Offerta1.text) > p2.soldi)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {

                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
        }
        else if (p3.attivo == true)
        {
            if (int.Parse(Offerta1.text) > p3.soldi)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {

                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
        }
        else if (p4.attivo == true)
        {
            if (int.Parse(Offerta1.text) > p4.soldi)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {

                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
        }
        else if (p5.attivo == true)
        {
            if (int.Parse(Offerta1.text) > p5.soldi)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {

                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
        }
        else if  (p6.attivo == true)
            {
            if (int.Parse(Offerta1.text) > p6.soldi)//prendo il saldo del player attivo al posto di 999// CurrentPlayerID.Soldi; 
            {

                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
        }

        //--------------------------------//
        //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 1"))
        if (player2.text.Equals("Player 1"))
        {
            if (int.Parse(Offerta2.text) > p1.soldi)//prendo il saldo del player selezionato al posto di 999// CurrentPlayerID.Soldi; 

            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
        
        }
            else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 2"))
            if (player2.text.Equals("Player 2"))
        {
            if (int.Parse(Offerta2.text) > p2.soldi)
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
           }
            else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 3"))
            if (player2.text.Equals("Player 3"))
        {
            if (int.Parse(Offerta2.text) > p3.soldi)
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
            }
            else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 4"))
            if (player2.text.Equals("Player 4"))
        {
            if (int.Parse(Offerta2.text) > p4.soldi)
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
            }
            else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 5"))
            if (player2.text.Equals("Player 5"))
        {
            if (int.Parse(Offerta2.text) > p5.soldi)
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
            }
            else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 6"))
            if (player2.text.Equals("Player 6"))
        {
            if (int.Parse(Offerta2.text) > p6.soldi)
            {
                Nonhaisoldi.active = true;
                b.gameObject.active = true;
                attiva = false;
            }
            }
           if( attiva == true)
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

        int oppertap1 = 0;
        int offertap2 = 0;
        
        //COSE DA FARE QUANDO SI ACCETTA
        /*InputField inf1 = GameObject.Find("Inserisci_Soldi1").GetComponent<InputField>();
        InputField inf2 = GameObject.Find("Inserisci_Soldi2").GetComponent<InputField>();
        if (inf1.text != null)
            soldidarimuovere = int.Parse(inf1.text);
        if (inf2.text != null)
            soldidaaggiungere = int.Parse(inf2.text);*/

        if (Offerta1 != null)
            oppertap1 = int.Parse(Offerta1.text); //soldi offerti da p1
        if (Offerta2 != null)
            offertap2 = int.Parse(Offerta2.text);//soldi offerti da p2



        //PROBLEMA Capire come prendere i parametri del giocatore, probabile mi serva la struttura dati del giocatore, che non è ancora stata creata
        int saldoPlayer1 = 0; // int.Parse(GameObject.Find("SOLDI1").GetComponent<Text>().text); //Prendo il saldo del giocatore corrente //state
        int saldoPlayer2 = 0;

        if (p1.attivo == true)
        {
            //saldoPlayer1 = p1.soldi;
            p1.soldi = p1.soldi + offertap2 - oppertap1;
        }
        else if (p2.attivo == true)
        {
            p2.soldi = p2.soldi + offertap2 - oppertap1;
        }
        else if (p3.attivo == true)
        {
            p3.soldi = p3.soldi + offertap2 - oppertap1;
        }
        else if (p4.attivo == true)
        {
            p4.soldi = p4.soldi + offertap2 - oppertap1;
        }
        else if (p5.attivo == true)
        {
            p5.soldi = p5.soldi + offertap2 - oppertap1;
        }
        else if (p6.attivo == true)
        {
            p6.soldi = p6.soldi + offertap2 - oppertap1;
        }
        //-------------------------------------------
        //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals ("Player 1"))
        if (player2.text.Equals("Player 1"))
        {
            //saldoPlayer2 = int.Parse(GameObject.Find("SOLDI2").GetComponent<Text>().text); //Prendo il saldo del giocatore selezionato //state
            //saldoPlayer2 = p1.soldi;
            p1.soldi = p1.soldi + oppertap1 - offertap2;
        }
        else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 2"))
        if (player2.text.Equals("Player 2"))
        {
            p2.soldi = p2.soldi + oppertap1 - offertap2;
        }
        else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 3"))
        if (player2.text.Equals("Player 3"))
        {
            p3.soldi = p3.soldi + oppertap1 - offertap2;
        }
        else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 4"))
        if (player2.text.Equals("Player 4"))
        {
            p4.soldi = p4.soldi + oppertap1 - offertap2;
        }
        else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 5"))
        if (player2.text.Equals("Player 5"))
        {
            p5.soldi = p5.soldi + oppertap1 - offertap2;
        }
        else //if (GameObject.Find("Player2").GetComponent<Text>().text.Equals("Player 6"))
        if (player2.text.Equals("Player 6"))
        {
            p6.soldi = p6.soldi + oppertap1 - offertap2;
        }


        
        /*saldoPlayer1 = saldoPlayer1 + soldidaaggiungere - soldidarimuovere; //Se non ci sono offrte sui soldi somma e sottrae 0, quindi rimane invarito, modifico lo il paramentro nel palyer
        saldoPlayer2 = saldoPlayer2 + soldidaaggiungere - soldidarimuovere;*/
        /*GameObject.Find("SOLDI1").GetComponent<Text>().text = saldoPlayer1.ToString();
        GameObject.Find("SOLDI2").GetComponent<Text>().text = saldoPlayer2.ToString();*/


        GameObject.Find("TRATTATIVA").active = false;

        // SceneManager.LoadScene(2);
    }

    public void offri()
    {
        offri1.active = false;
        accetta1.active = true;
        controproposta1.active = false;
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
