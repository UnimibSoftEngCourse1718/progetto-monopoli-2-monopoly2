using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casella : MonoBehaviour
{
    // Forse ho applicato lo strategy
    public Casella prossimaCasella;

    public virtual void Fermata(giocatore giocatoreDiTurno)
    {
        // Se il giocatore passa dalla casella 1, il via, e non è stato
        // diretto alla prigione allora prende i soldi
        if (this.name == "1" && giocatoreDiTurno.contatorePrigione < 0)
            giocatoreDiTurno.Paga(-200);
    }
}