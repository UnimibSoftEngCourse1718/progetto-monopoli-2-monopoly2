﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateController : MonoBehaviour
{
    static public int giocatoriSelezionati = 6;
    public int NumberOfPlayers;
    public GameObject[] listaGiocatori;
    public int CurrentPlayerId = 0;
    Button pulsante;
    public int DiceTotal;
    public int doppio;
    public bool IsDoneRolling = false;
    public bool IsDoneClicking = false;
    public SchermataAvviso schermataAvviso;
    public GameObject uscitaPrigione;
    public GameObject NoLegalMovesPopup;
    public bool verifica = false;
    public float tempoPerSpostamento= 0.15f;
    giocatore giocatoreAttivo = null;

    void Start()
    {
        NumberOfPlayers = giocatoriSelezionati;
        for (int i = 6; i > NumberOfPlayers; i--) 
        {
            Destroy(GameObject.Find("Player" + i));
            Destroy(GameObject.Find("P" + i));
        }

        listaGiocatori = new GameObject[NumberOfPlayers];
        for (int i = 1; i <= NumberOfPlayers; i++)
        {
            listaGiocatori[i - 1] = GameObject.Find("P" + i);
        }
        giocatoreAttivo = this.getGiocatoreAttivo();
        giocatoreAttivo.GetComponent<BoxCollider>().enabled = true;
    }

    public void NewTurn()
    {
        giocatoreAttivo.GetComponent<BoxCollider>().enabled = false;
        giocatoreAttivo = null;
        IsDoneRolling = false;
        IsDoneClicking = false;
        verifica = false;
        if (doppio == 0)
        {
            for (int i = CurrentPlayerId; i < listaGiocatori.Length; i++)
            {
                if (i == listaGiocatori.Length - 1)
                {
                    i = -1;
                    CurrentPlayerId = 0;
                }

                if (listaGiocatori[i + 1] != null)
                {
                    CurrentPlayerId = i + 1;
                    i = listaGiocatori.Length;
                }
            }
        }

        giocatoreAttivo = this.getGiocatoreAttivo();
        giocatoreAttivo.GetComponent<BoxCollider>().enabled = true;
        uscitaPrigione.SetActive(giocatoreAttivo.uscitaDiPrigione);

        if (giocatoreAttivo.contatorePrigione != -1)
        {
            giocatoreAttivo.partenza.Fermata(giocatoreAttivo);
        }
    }

    public giocatore getGiocatoreAttivo()
    {
        if (this.giocatoreAttivo == null)
        {
            foreach (giocatore item in GameObject.FindObjectsOfType<giocatore>())
                if (item.attivo)
                    this.giocatoreAttivo = item;
        }
        return giocatoreAttivo;
    }

    public void RimuoviGiocatore(giocatore giocatoreDaRimuovere)
    {
        if (giocatoreDaRimuovere == null)
            return;

        Terreno terreno;
        foreach (CasellaAcquistabile item in giocatoreDaRimuovere.proprieta)
        {
            terreno = item as Terreno;
            terreno.RimuoviEdifici();
            item.proprietario = null;
            item.CambioProprietario();
        }
        this.Avviso(giocatoreDaRimuovere.name + " È Stato eliminato");
        DestroyImmediate(GameObject.Find(giocatoreDaRimuovere.name));

        if (GameObject.FindObjectsOfType<giocatore>().Length == 1)
        {
            this.Avviso("Partita Finita");
            GameObject.Find("TIRA").SetActive(false);
            GameObject.Find("PASSA").SetActive(false);
            GameObject.Find("COSTRUISCI").SetActive(false);
        }
    }

    public void Avviso(string messaggio)
    {
        schermataAvviso.gameObject.SetActive(true);
        schermataAvviso.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text = messaggio;
    }
}