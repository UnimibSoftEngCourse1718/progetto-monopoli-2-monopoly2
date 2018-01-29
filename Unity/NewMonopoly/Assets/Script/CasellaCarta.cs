using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasellaCarta : Casella
{
    protected Carta[] carte;

    //Pesca una carta dal mazzo a caso e ne applica l'effetto
    public override void Fermata(giocatore giocatoreDiTurno)
    {
        int i = UnityEngine.Random.Range(0, carte.Length);
        Debug.Log(carte[i].testo);
        carte[i].Effetto(giocatoreDiTurno);
        carte[i].Disegna();
    }
}
