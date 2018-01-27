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
    public override void Fermata(Giocatore giocatoreDiTurno)
    {
        // TODO // Da correggere l'animazione e da evitare i soldi del passaggio del via
        giocatoreDiTurno.contatorePrigione = 0;
        giocatoreDiTurno.SetNewTargetPosition(prigione.transform.position);
        giocatoreDiTurno.partenza = prigione;
    }
}
