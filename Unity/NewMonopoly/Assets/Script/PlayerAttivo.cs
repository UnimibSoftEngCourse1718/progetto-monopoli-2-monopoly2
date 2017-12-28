using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;

public class PlayerAttivo : MonoBehaviour
{
    public GameObject bga;
    public GameObject bga1;
    
    public GameObject offri1;
    public GameObject accetta1;
    public GameObject controproposta1;
    public GameObject rifiuta1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

    public void accetta()
    {
        
        int soldidaaggiungere = 0;
        int soldidarimuovere = 0;

        //COSE DA FARE QUANDO SI ACCETTA
        InputField inf1 = GameObject.Find("Inserisci_Soldi1").GetComponent<InputField>();
        InputField inf2 = GameObject.Find("Inserisci_Soldi2").GetComponent<InputField>();


        if (inf1.text != null)
            soldidarimuovere = int.Parse(inf1.text);
        if (inf2.text != null)
            soldidaaggiungere = int.Parse(inf2.text);

        SceneManager.LoadScene(2);
        //PROBLEMA Capire come prendere i parametri del giocatore, probabile mi serva la struttura dati del giocatore, che non è ancora stata creata
        int saldoPlayer1 = int.Parse(GameObject.Find("SOLDI1").GetComponent<Text>().text);
        int saldoPlayer2 = int.Parse(GameObject.Find("SOLDI2").GetComponent<Text>().text);


        saldoPlayer1 = saldoPlayer1 + soldidaaggiungere - soldidarimuovere; //Se non ci sono offrte sui soldi somma e sottrae 0, quindi rimane invarito
        saldoPlayer2 = saldoPlayer2 + soldidaaggiungere - soldidarimuovere;
        GameObject.Find("SOLDI1").GetComponent<Text>().text = saldoPlayer1.ToString();
        GameObject.Find("SOLDI2").GetComponent<Text>().text = saldoPlayer2.ToString();
        
    }

    public void controproposta()
    {
        bga.active = true;
        bga1.active = false;
    }

    


}

