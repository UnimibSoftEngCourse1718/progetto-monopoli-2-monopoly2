using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasellaInPrigione : Casella
{
    Prigione prigione;
    private void Start()
    {
        prigione = GameObject.FindObjectOfType<Prigione>();
    }
    public override void Fermata(giocatore giocatoreDiTurno)
    {
        GameObject.FindObjectOfType<StateController>().Avviso("Vai in prigione");
        giocatoreDiTurno.contatorePrigione = 0;
        giocatoreDiTurno.partenza = giocatoreDiTurno.Muovi(giocatoreDiTurno.partenza, prigione);
    }
}