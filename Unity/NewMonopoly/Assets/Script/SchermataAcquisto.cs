using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchermataAcquisto : MonoBehaviour
{
    public Terreno Terreno { get; set; }
    public Societa Societa { get; set; }
    public Stazione Stazione { get; set; }
    public GameObject schermata;
    giocatore giocatoreDiturno = null;

    public void Visualizza ()
    {
        if (giocatoreDiturno == null)
        {
            giocatoreDiturno = GameObject.FindObjectOfType<StateController>().getGiocatoreAttivo();
        }
        if (Terreno != null)
        {
            this.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text =
                Terreno.nomeCasella + "\n\nPREZZO : " + Terreno.costo + "\nPEDAGGIO : " + Terreno.pedaggio +
                "\nCON 1 CASA : " + Terreno.pedaggio1Casa + "\nCON 2 CASA : " + Terreno.pedaggio2Case +
                "\nCON 3 CASA : " + Terreno.pedaggio3Case + "\nCON 4 CASA : " + Terreno.pedaggio4Case +
                "\nCON ALBERGO : " + Terreno.pedaggioAlbergo + "\nCOSTO EDIFICIO : " + Terreno.costoEdificio;
        }
        else if (Societa != null)
        {
            this.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text =
                Societa.nomeCasella + "\n\n" + "PREZZO : " + Societa.Costo;
        }
        else if (Stazione != null)
        {
            this.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text =
                Stazione.nomeCasella + "\n\n" + "PREZZO : " + Stazione.Costo + "\nPEDAGGIO : " + Stazione.Pedaggio +
                "\nCON 2 STAZIONI : " + Stazione.Pedaggio2Stazioni + "\nCON 3 STAZIONI : " + Stazione.Pedaggio3Stazioni +
                "\nCON 4 STAZIONI : " + Stazione.Pedaggio4Stazioni;
        }
        giocatoreDiturno.controller.DisattivaPulsantiFineTurno();
        schermata.SetActive(true);
    }

    public void PulsanteAcquista()
    {
        if (giocatoreDiturno != null && Terreno != null && Terreno.costo <= giocatoreDiturno.soldi)
        {
            giocatoreDiturno.TrasferimentoDenaro(-Terreno.costo);
            giocatoreDiturno.AggiungiProprieta(Terreno);
        }
        else if (giocatoreDiturno != null && Societa != null && Societa.Costo <= giocatoreDiturno.soldi)
        {
            giocatoreDiturno.TrasferimentoDenaro(-Societa.Costo);
            giocatoreDiturno.AggiungiProprieta(Societa);
        }
        else if (giocatoreDiturno != null && Stazione != null && Stazione.Costo <= giocatoreDiturno.soldi)
        {
            giocatoreDiturno.TrasferimentoDenaro(-Stazione.Costo);
            giocatoreDiturno.AggiungiProprieta(Stazione);
        }

        PulsanteAnnulla();
    }

    public void PulsanteAnnulla()
    {
        giocatoreDiturno.controller.AttivaPulsantiFineTurno();
        this.giocatoreDiturno = null;
        this.Terreno = null;
        this.Societa = null;
        this.Stazione = null;
        schermata.SetActive(false);
    }
}
