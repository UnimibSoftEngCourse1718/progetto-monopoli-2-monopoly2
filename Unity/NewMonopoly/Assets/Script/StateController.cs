using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateController : MonoBehaviour
{
    // Modificate questo numero per avere n giocatori senza dover 
    // far partire il play di unity dal menu principale
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

    // Use this for initialization
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
    }

    public void NewTurn()
    {
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

        giocatore giocatoreAttivo = null;
        foreach (giocatore item in GameObject.FindObjectsOfType<giocatore>())
            if (item.attivo)
                giocatoreAttivo = item;

        uscitaPrigione.SetActive(giocatoreAttivo.uscitaDiPrigione);
        // Controllo se il giocatore è in prigione
        if (giocatoreAttivo.contatorePrigione != -1)
        {
            giocatoreAttivo.partenza.Fermata(giocatoreAttivo);
            // TODO // Disabilitare i tasti tira,passa,costruisci
        }
    }

    // Update is called once per frame
    void Update()
    {
        // È finito il turno?
        if (IsDoneRolling && IsDoneClicking && verifica == true )
        {
            NewTurn();
        }
    }

    public void RimuoviGiocatore(giocatore g)
    {
        if (g == null)
            return;

        Terreno terreno;
        foreach (CasellaAcquistabile item in g.proprieta)
        {
            terreno = item as Terreno;
            terreno.RimuoviEdifici();
            item.proprietario = null;
            item.CambioProprietario();
        }
        this.Avviso(g.name + " È Stato eliminato");
        //GameObject.Find("Messaggi").GetComponent<Text>().text = g.name + " È Stato eliminato";
        DestroyImmediate(GameObject.Find(g.name));

        if (GameObject.FindObjectsOfType<giocatore>().Length == 1)
        {
            this.Avviso("Partita Finita");
            //GameObject.Find("Messaggi").GetComponent<Text>().text += "\n\nPartita Finita";
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