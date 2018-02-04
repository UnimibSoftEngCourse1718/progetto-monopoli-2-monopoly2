using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tassa : Casella
{
    public int valoreTassa;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        giocatoreDiTurno.TrasferimentoDenaro(-valoreTassa);
        giocatoreDiTurno.controller.AttivaPulsantiFineTurno();
    }
}
