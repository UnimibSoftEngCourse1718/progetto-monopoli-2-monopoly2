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

    public void offri()
    {
        offri1.SetActive(false);
        accetta1.SetActive(true);
        controproposta1.SetActive(true);
        rifiuta1.SetActive(true);
        bga.SetActive(false);
        bga1.SetActive(true);
    }

    public void accetta()
    {
        int soldidaaggiungere = 0;
        int soldidarimuovere = 0;

        InputField inf1 = GameObject.Find("Inserisci_Soldi1").GetComponent<InputField>();
        InputField inf2 = GameObject.Find("Inserisci_Soldi2").GetComponent<InputField>();

        if (inf1.text != null)
            soldidarimuovere = int.Parse(inf1.text);
        if (inf2.text != null)
            soldidaaggiungere = int.Parse(inf2.text);

        SceneManager.LoadScene(2);

        int saldoPlayer1 = int.Parse(GameObject.Find("SOLDI1").GetComponent<Text>().text);
        int saldoPlayer2 = int.Parse(GameObject.Find("SOLDI2").GetComponent<Text>().text);

        saldoPlayer1 = saldoPlayer1 + soldidaaggiungere - soldidarimuovere;
        saldoPlayer2 = saldoPlayer2 + soldidaaggiungere - soldidarimuovere;
        GameObject.Find("SOLDI1").GetComponent<Text>().text = saldoPlayer1.ToString();
        GameObject.Find("SOLDI2").GetComponent<Text>().text = saldoPlayer2.ToString();
    }

    public void controproposta()
    {
        bga.SetActive(true);
        bga1.SetActive(false);
    }

    


}

