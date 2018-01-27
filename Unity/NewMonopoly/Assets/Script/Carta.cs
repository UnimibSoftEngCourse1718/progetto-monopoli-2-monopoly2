using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
    string testo { get; set; }
    int valore { get; set; }
    int movimento { get; set; }

    public Carta(string Testo, int Valore, int Movimento)
    {
        testo = Testo;
        valore = Valore;
        movimento = Movimento;
    }
    
    public void Effetto()
    {
        if (valore == 0 && movimento == 0)
        {
            //carta salva dalla prigione
            return;
        }
        // giocatore.soldi += valore;
        if (movimento != 0)
        {
            // sposta giocatore alla casella numero "movimento"
        }
        return;
    }

    public void Disegna()
    {
        // posso farlo
        // disegna a schermo una scheda con dentro la stringa "testo"
    }
}
