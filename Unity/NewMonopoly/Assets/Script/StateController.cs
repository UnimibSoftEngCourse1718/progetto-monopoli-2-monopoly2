using System.Collections;
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
    public float tempoPerSpostamento;
    giocatore giocatoreAttivo = null;
    public Button Tira { get; set; }
    public Button Passa { get; set; }
    public Button Costruisci { get; set; }

    void Start()
    {
        tempoPerSpostamento = 0.15f;
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
        //giocatoreAttivo.GetComponent<BoxCollider>().enabled = true;

        foreach (Button item in GameObject.FindObjectsOfType<Button>())
        {
            if (item.name == "TIRA")
                Tira = item;
            if (item.name == "PASSA")
                Passa = item;
            if (item.name == "COSTRUISCI")
                Costruisci = item;
        }
        this.Passa.interactable = false;
        this.Costruisci.interactable = false;
    }

    public void NewTurn()
    {
        Tira.interactable = true;
        Passa.interactable = false;
        Costruisci.interactable = false;
        giocatoreAttivo.GetComponent<BoxCollider>().enabled = false;
        giocatoreAttivo = null;
        this.verifica = false;
        giocatoreAttivo = this.getGiocatoreAttivo();
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
            if (terreno != null)
            {
                terreno.RimuoviEdifici();
            }
            item.proprietario = null;
            item.CambioProprietario();
        }
        this.Avviso(giocatoreDaRimuovere.name + " È Stato eliminato", false);
        DestroyImmediate(GameObject.Find(giocatoreDaRimuovere.name));
        this.Passa.interactable = true;

        if (GameObject.FindObjectsOfType<giocatore>().Length == 1)
        {
            this.Avviso("Partita Finita", false);
            GameObject.Find("TIRA").SetActive(false);
            GameObject.Find("PASSA").SetActive(false);
            GameObject.Find("COSTRUISCI").SetActive(false);
        }
        this.IsDoneClicking = true;
        this.IsDoneRolling = true;
        this.Passa.onClick.Invoke();
    }

    public void Avviso(string messaggio, bool attivoPulsanti)
    {
        schermataAvviso.gameObject.SetActive(true);
        schermataAvviso.attivoPulsanti = attivoPulsanti;
        schermataAvviso.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text = messaggio;
    }
}