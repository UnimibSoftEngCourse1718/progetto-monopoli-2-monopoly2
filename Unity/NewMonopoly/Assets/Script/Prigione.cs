﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prigione : Casella
{
    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (giocatoreDiTurno.contatorePrigione == -1)
            return;


        //sei in prigione
    }
}
