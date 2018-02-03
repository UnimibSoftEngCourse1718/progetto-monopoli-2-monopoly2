using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasellaCarta : Casella
{
    protected Carta[] carte;
    protected string tipo;
    protected int i;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        i = UnityEngine.Random.Range(0, 16);
        if (carte[i] == null)
        {
            GameObject.FindObjectOfType<StateController>().Avviso("Non succede nulla", true);
        }
        carte[i].Effetto(giocatoreDiTurno);
        GameObject.FindObjectOfType<StateController>().Avviso(tipo + "\n\n" + carte[i].testo, carte[i].attivaPulsanti);
    }
}
