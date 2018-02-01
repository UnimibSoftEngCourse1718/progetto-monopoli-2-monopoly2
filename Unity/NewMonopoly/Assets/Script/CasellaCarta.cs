using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasellaCarta : Casella
{
    protected Carta[] carte;
    protected string tipo;
    protected int i;

    //Pesca una carta dal mazzo a caso e ne applica l'effetto
    public override void Fermata(giocatore giocatoreDiTurno)
    {
        i = UnityEngine.Random.Range(0, 16);
        carte[i].Effetto(giocatoreDiTurno);
        GameObject.FindObjectOfType<StateController>().Avviso(tipo + "\n\n" + carte[i].testo);
        Debug.Log(i + " " + carte[i].testo);
    }
}
