using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasellaCarta : Casella
{
    protected Carta[] carte = new Carta[16];

    //Pesca una carta dal mazzo a caso e ne applica l'effetto
    void PescaCarta()
    {
        int i = Random.Range(1, 17);
        carte[i].Effetto();
        carte[i].Disegna();
    }
}
