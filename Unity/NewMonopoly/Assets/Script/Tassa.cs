using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tassa : Casella
{
    public int valoreTassa;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (giocatoreDiTurno.soldi - valoreTassa >= 0)
        {
            giocatoreDiTurno.soldi -= valoreTassa;
        }
        else
        {
            // TODO // Non ho abbastanza soldi
        }
        return;
    }
}
