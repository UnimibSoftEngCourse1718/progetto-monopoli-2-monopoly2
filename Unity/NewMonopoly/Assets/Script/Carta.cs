using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carta
{
    public string testo { get; set; }
    int valore;
    int movimento;
    public bool AttivaPulsanti { get; set; }

    public Carta(string Testo, int Valore, int Movimento, bool attivaPulsanti)
    {
        this.testo = Testo;
        this.valore = Valore;
        this.movimento = Movimento;
        this.AttivaPulsanti = attivaPulsanti;
    }

    public void Effetto(giocatore giocatoreDiTurno)
    {
        if (valore == 0 && movimento == 0)
        {
            giocatoreDiTurno.uscitaDiPrigione = true;
            GameObject.FindObjectOfType<StateController>().uscitaPrigione.SetActive(true);
            return;
        }

        giocatoreDiTurno.TrasferimentoDenaro(this.valore);

        if (movimento == -3)
        {
            giocatoreDiTurno.contatorePrigione = -2;
            movimento = int.Parse(giocatoreDiTurno.partenza.name) - 3;
            if (movimento <= 0)
                movimento += 40;
        }

        if (movimento != 0)
        {
            GameObject.FindObjectOfType<StateController>().IsDoneClicking = false;

            Casella[] caselle = GameObject.FindObjectsOfType<Casella>();
            Casella casella = null;
            foreach (Casella item in caselle)
                if (item.name == movimento.ToString())
                    casella = item;
            if (casella.name == "11")
            {
                giocatoreDiTurno.contatorePrigione = 0;
            }

            giocatoreDiTurno.partenza = giocatoreDiTurno.Muovi(giocatoreDiTurno.partenza, casella);
        }
    }
}
