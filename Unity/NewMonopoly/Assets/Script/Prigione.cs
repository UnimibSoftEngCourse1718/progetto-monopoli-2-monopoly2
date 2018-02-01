using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prigione : Casella
{
    StateController controller;
    public GameObject schermata;
    giocatore giocatoreInPrigione;
    Button tira, passa;
    float tempo;

    private void Start()
    {
        controller = GameObject.FindObjectOfType<StateController>();
        foreach (Button item in GameObject.FindObjectsOfType<Button>())
        {
            if (item.name=="TIRA")
                tira = item;
            else if (item.name == "PASSA")
                passa = item;
        }

    }

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (giocatoreDiTurno.contatorePrigione == -1)
        {
            return;
        }
        else if (giocatoreDiTurno.contatorePrigione == 0)
        {
            giocatoreDiTurno.contatorePrigione++;
        }
        else if (giocatoreDiTurno.contatorePrigione == 3)
        {
            giocatoreDiTurno.Paga(125);
            giocatoreDiTurno.contatorePrigione = -1;
            controller.Avviso("Sono passati tre turni, hai pagato 125$ per uscire");
        }
        else
        {
            //Abilito schermata prigione
            giocatoreInPrigione = giocatoreDiTurno;
            this.abilitaSchermata();
        }
    }

    public void pulsanteCarta()
    {
        // O uso la carta
        if (giocatoreInPrigione.uscitaDiPrigione)
        {
            giocatoreInPrigione.uscitaDiPrigione = false;
            giocatoreInPrigione.contatorePrigione = -1;
            controller.uscitaPrigione.SetActive(false);
            controller.IsDoneClicking = false;
            controller.IsDoneRolling = false;
            this.disabilitaSchermata();
        }
    }

    public void pulsanteDadi()
    {
        // O tiro i dadi
        RANDOM dado = GameObject.FindObjectOfType<RANDOM>();
        controller.IsDoneRolling = false;
        controller.IsDoneClicking = false;
        dado.Randomizza();

        if (int.Parse(dado.text[0].text) != int.Parse(dado.text[1].text))
        {
            // fuga fallita
            giocatoreInPrigione.contatorePrigione++;
            this.disabilitaSchermata();
        }
        else
        {
            giocatoreInPrigione.contatorePrigione = -1;
            this.disabilitaSchermata();
        }
    }

    public void pulsantePaga()
    {
        // Se ho 125 pago ed esco
        if (giocatoreInPrigione.soldi >= 125)
        {
            giocatoreInPrigione.Paga(125);
            giocatoreInPrigione.contatorePrigione = -1;
            controller.IsDoneClicking = false;
            controller.IsDoneRolling = false;
            this.disabilitaSchermata();
        }
    }

    public void abilitaSchermata()
    {
        tira.interactable = false;
        passa.interactable = false;
        schermata.SetActive(true);
        tempo = Time.timeScale;
        Time.timeScale = 0;
    }

    public void disabilitaSchermata()
    {
        tira.interactable = true;
        passa.interactable = true;
        schermata.SetActive(false);
        Time.timeScale = tempo;
    }
}
