using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tassa : Casella
{
    public int valoreTassa;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        // TODO // Non ho abbastanza soldi
        giocatoreDiTurno.soldi -= valoreTassa;
        return;
    }
}
