using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prigione : Casella
{
    StateController controller;
    public GameObject schermata;
    giocatore giocatoreInPrigione;
    float tempo;

    private void Start()
    {
        controller = GameObject.FindObjectOfType<StateController>();
    }

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (giocatoreDiTurno.contatorePrigione == -1)
        {
            giocatoreDiTurno.controller.Passa.interactable = true;
            giocatoreDiTurno.controller.Costruisci.interactable = true;
        }
        else if (giocatoreDiTurno.contatorePrigione == 0)
        {
            giocatoreDiTurno.controller.Passa.interactable = true;
            giocatoreDiTurno.controller.Costruisci.interactable = true;
            giocatoreDiTurno.contatorePrigione++;
        }
        else if (giocatoreDiTurno.contatorePrigione == 3)
        {
            giocatoreDiTurno.TrasferimentoDenaro(-125);
            giocatoreDiTurno.contatorePrigione = -1;
            controller.Avviso("Sono passati tre turni, hai pagato 125$ per uscire", false);
            controller.Tira.interactable = true;
        }
        else
        {
            giocatoreInPrigione = giocatoreDiTurno;
            this.abilitaSchermata();
        }
    }

    public void pulsanteCarta()
    {
        if (giocatoreInPrigione.uscitaDiPrigione)
        {
            giocatoreInPrigione.uscitaDiPrigione = false;
            giocatoreInPrigione.contatorePrigione = -1;
            controller.uscitaPrigione.SetActive(false);
            controller.IsDoneClicking = false;
            controller.IsDoneRolling = false;
            controller.Tira.interactable = true;
            this.disabilitaSchermata(true);
        }
    }

    public void pulsanteDadi()
    {
        RANDOM dado = GameObject.FindObjectOfType<RANDOM>();
        controller.IsDoneRolling = false;
        controller.IsDoneClicking = false;
        dado.Randomizza();

        if (int.Parse(dado.text[0].text) != int.Parse(dado.text[1].text))
        {
            giocatoreInPrigione.contatorePrigione++;
            controller.IsDoneRolling = true;
            controller.IsDoneClicking = true;
            this.disabilitaSchermata(true);
            controller.Avviso("Hai tirato doppio!\nPuoi uscire e ti muovi di quanto hai tirato", false);
        }
        else
        {
            giocatoreInPrigione.contatorePrigione = -1;
            // Da simulare il tiro
            this.disabilitaSchermata(false);
        }
    }

    public void pulsantePaga()
    {
        if (giocatoreInPrigione.soldi >= 125)
        {
            giocatoreInPrigione.TrasferimentoDenaro(-125);
            giocatoreInPrigione.contatorePrigione = -1;
            controller.IsDoneClicking = false;
            controller.IsDoneRolling = false;
            controller.Tira.interactable = true;
            this.disabilitaSchermata(false);
        }
    }

    public void abilitaSchermata()
    {
        controller.Tira.interactable = false;
        controller.Passa.interactable = false;
        controller.Costruisci.interactable = false;
        schermata.SetActive(true);
        tempo = Time.timeScale;
        Time.timeScale = 0;
    }

    public void disabilitaSchermata(bool pulsanti)
    {
        if (pulsanti)
        {
            controller.Passa.interactable = true;
            controller.Costruisci.interactable = true;
        }
        schermata.SetActive(false);
        Time.timeScale = tempo;
    }
}
