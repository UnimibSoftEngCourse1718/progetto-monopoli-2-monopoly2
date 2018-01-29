using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta
{
    public string testo { get; set; }
    int valore { get; set; }
    int movimento { get; set; }

    public Carta(string Testo, int Valore, int Movimento)
    {
        testo = Testo;
        valore = Valore;
        movimento = Movimento;
    }
    
    public void Effetto(giocatore giocatoreDiTurno)
    {
        if (valore == 0 && movimento == 0)
        {
            //carta salva dalla prigione
            giocatoreDiTurno.uscitaDiPrigione = true;
            return;
        }

        giocatoreDiTurno.soldi += this.valore;

        if (movimento == -3)
        {
            // sposta giocatore di 3 caselle indietro
            movimento = int.Parse(giocatoreDiTurno.partenza.name) - 3;
            if (movimento <= 0)
                movimento += 40;
        }

        if (movimento != 0)
        {
            // sposta giocatore alla casella numero "movimento"
            GameObject casella = GameObject.Find(movimento.ToString());
            giocatoreDiTurno.SetNewTargetPosition(casella.transform.position);
            return;
        }
    }

    public void Disegna()
    {
        // TODO //
        // disegna a schermo una scheda con dentro la stringa "testo"
        return;
    }
}
