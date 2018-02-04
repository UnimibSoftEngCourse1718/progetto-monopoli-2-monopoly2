using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateController : MonoBehaviour
{
    static public int giocatoriSelezionati = 6;
    GameObject[] listaGiocatori { get; set; }
    public int CurrentPlayerId { get; set; }
    giocatore giocatoreAttivo { get; set; }

    public int DiceTotal { get; set; }
    public int Doppio { get; set; }
    public bool IsDoneRolling { get; set; }
    public bool IsDoneClicking { get; set; }

    public SchermataAvviso schermataAvviso;
    public GameObject uscitaPrigione;
    public Button Tira { get; set; }
    public Button Passa { get; set; }
    public Button Costruisci { get; set; }
    public Button[] trattativa;

    void Start()
    {
        IsDoneRolling = false;
        IsDoneClicking = false;
        for (int i = 6; i > giocatoriSelezionati; i--) 
        {
            Destroy(GameObject.Find("Player" + i));
            Destroy(GameObject.Find("P" + i));
        }

        listaGiocatori = new GameObject[giocatoriSelezionati];
        for (int i = 1; i <= giocatoriSelezionati; i++)
        {
            listaGiocatori[i - 1] = GameObject.Find("P" + i);
        }
        CurrentPlayerId = 0;
        giocatoreAttivo = null;
        giocatoreAttivo = this.getGiocatoreAttivo();

        foreach (Button item in GameObject.FindObjectsOfType<Button>())
        {
            if (item.name == "TIRA")
                Tira = item;
            if (item.name == "PASSA")
                Passa = item;
            if (item.name == "COSTRUISCI")
                Costruisci = item;
        }
        this.DisattivaPulsantiFineTurno();
    }

    public void NewTurn()
    {
        Tira.interactable = true;
        this.DisattivaPulsantiFineTurno();

        if (giocatoreAttivo != null)
        {
            giocatoreAttivo.GetComponent<BoxCollider>().enabled = false;
            giocatoreAttivo = null;
        }

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
                if (item.Attivo)
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
        trattativa[CurrentPlayerId].interactable = false;
        trattativa[CurrentPlayerId] = null;
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

    public void DisattivaPulsantiFineTurno()
    {
        foreach (Button item in trattativa)
        {
            if (item != null)
            {
                item.interactable = false;
            }
        }
        this.Passa.interactable = false;
        this.Costruisci.interactable = false;
    }

    public void AttivaPulsantiFineTurno()
    {
        foreach (Button item in trattativa)
        {
            if (item != null)
            {
                item.interactable = true;
            }
        }
        trattativa[CurrentPlayerId].interactable = false;
        this.Passa.interactable = true;
        this.Costruisci.interactable = true;
    }

    public void Avviso(string messaggio, bool attivoPulsanti)
    {
        schermataAvviso.gameObject.SetActive(true);
        schermataAvviso.AttivoPulsanti = attivoPulsanti;
        schermataAvviso.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text = messaggio;
    }
}