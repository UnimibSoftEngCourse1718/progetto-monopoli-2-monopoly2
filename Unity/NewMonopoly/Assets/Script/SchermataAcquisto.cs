using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchermataAcquisto : MonoBehaviour
{
    public Terreno terreno;
    public Societa societa;
    public Stazione stazione;
    public GameObject schermata;

    public void Visualizza ()
    {
        if (terreno != null)
        {
            this.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text =
                terreno.nomeCasella + "\n\nPREZZO : " + terreno.costo + "\nPEDAGGIO : " + terreno.pedaggio +
                "\nCON 1 CASA : " + terreno.pedaggio1Casa + "\nCON 2 CASA : " + terreno.pedaggio2Case +
                "\nCON 3 CASA : " + terreno.pedaggio3Case + "\nCON 4 CASA : " + terreno.pedaggio4Case +
                "\nCON ALBERGO : " + terreno.pedaggioAlbergo + "\nIPOTECA : " + terreno.ipoteca + 
                "\nCOSTO EDIFICIO : " + terreno.costoEdificio;
        }
        else if (societa != null)
        {
            this.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text =
                societa.nomeCasella + "\n\n" + "PREZZO : " + societa.costo + "\nIPOTECA : " + societa.ipoteca;
        }
        else if (stazione != null)
        {
            this.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text =
                stazione.nomeCasella + "\n\n" + "PREZZO : " + stazione.costo + "\nPEDAGGIO : " + stazione.pedaggio +
                "\nCON 2 STAZIONI : " + stazione.pedaggio2Stazioni + "\nCON 3 STAZIONI : " + stazione.pedaggio3Stazioni +
                "\nCON 4 STAZIONI : " + stazione.pedaggio4Stazioni + "\nIPOTECA : " + stazione.ipoteca;
        }
        schermata.SetActive(true);
    }

    public void PulsanteAcquista()
    {
        giocatore giocatoreDiturno = null;
        foreach (giocatore item in GameObject.FindObjectsOfType<giocatore>())
        {
            if (item.attivo)
            {
                giocatoreDiturno = item;
            }
        }

        if (giocatoreDiturno != null && terreno != null && terreno.costo <= giocatoreDiturno.soldi)
        {
            giocatoreDiturno.Paga(terreno.costo);
            giocatoreDiturno.AggiungiProprieta(terreno);
        }
        else if (giocatoreDiturno != null && societa != null && societa.costo <= giocatoreDiturno.soldi)
        {
            giocatoreDiturno.Paga(societa.costo);
            giocatoreDiturno.AggiungiProprieta(societa);
        }
        else if (giocatoreDiturno != null && stazione != null && stazione.costo <= giocatoreDiturno.soldi)
        {
            giocatoreDiturno.Paga(stazione.costo);
            giocatoreDiturno.AggiungiProprieta(stazione);
        }

        PulsanteAnnulla();
    }

    public void PulsanteAnnulla()
    {
        this.terreno = null;
        this.societa = null;
        this.stazione = null;
        schermata.SetActive(false);
    }
}
