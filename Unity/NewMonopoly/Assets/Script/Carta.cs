﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carta
{
    public string testo { get; set; }
    int valore { get; set; }
    int movimento { get; set; }

    public Carta(string Testo, int Valore, int Movimento)
    {
        testo = Testo;
        valore = Valore;
        movimento = Movimento;
    }
    
    public void Effetto(giocatore giocatoreDiTurno)
    {
        if (valore == 0 && movimento == 0)
        {
            //carta salva dalla prigione
            giocatoreDiTurno.uscitaDiPrigione = true;
            GameObject.FindObjectOfType<StateController>().uscitaPrigione.SetActive(true);
            return;
        }

        giocatoreDiTurno.Paga(-this.valore);

        if (movimento == -3)
        {
            // Imposta lo spostamento a 3 caselle indietro
            movimento = int.Parse(giocatoreDiTurno.partenza.name) - 3;
            if (movimento <= 0)
                movimento += 40;
        }

        if (movimento != 0)
        {
            GameObject.FindObjectOfType<StateController>().IsDoneClicking = false;
            // sposta giocatore alla casella numero "movimento"
            Casella[] caselle = GameObject.FindObjectsOfType<Casella>();
            Casella casella = null;
            foreach (Casella item in caselle)
            {
                if (item.name == movimento.ToString())
                {
                    casella = item;
                }
            }
            if (casella.name == "11")
            {
                giocatoreDiTurno.contatorePrigione = 0;
            }
            giocatoreDiTurno.partenza = giocatoreDiTurno.Muovi(giocatoreDiTurno.partenza, casella);
        }
    }

    public void Disegna()
    {
        GameObject.FindObjectOfType<StateController>().Avviso(this.testo);
    }
}
