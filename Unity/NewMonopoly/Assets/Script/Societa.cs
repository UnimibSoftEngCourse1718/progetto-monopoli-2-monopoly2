﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Societa : CasellaAcquistabile
{
    public int costo = 150;
    public int ipoteca = 75;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (proprietario == null)
        {
            schermataAcquisto.societa = this;
            schermataAcquisto.Visualizza();
        }
        else
        {
            int i = 0;
            foreach (Casella item in proprietario.proprieta)
            {
                if (item.name == "13" || item.name == "29")
                    i++;
            }

            if (i == 2)
                giocatoreDiTurno.TrasferimentoDenaro(-10 * int.Parse(GameObject.Find("Risultato Dadi").GetComponent<Text>().text));
            else
                giocatoreDiTurno.TrasferimentoDenaro(-4 * int.Parse(GameObject.Find("Risultato Dadi").GetComponent<Text>().text));
            giocatoreDiTurno.controller.Passa.interactable = true;
            giocatoreDiTurno.controller.Costruisci.interactable = true;
            giocatoreDiTurno.controller.AttivaTrattativa();
        }
    }
}
