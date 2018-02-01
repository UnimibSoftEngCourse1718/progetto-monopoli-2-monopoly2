using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Societa : CasellaAcquistabile
{
    //se si possiede solo una società il pedaggio è pari a 4 volte il tiro del dado
    //se si possiedono due società il pedaggio è pari a 10 volte il tiro del dado
    public int costo = 150;
    public int ipoteca = 75;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (proprietario == null)
        {
            schermataAcquisto.societa = this;
            schermataAcquisto.Visualizza();
        }
        else
        {
            // Terreno occupato // Pedaggio
            int i = 0;
            foreach (Casella item in proprietario.proprieta)
            {
                if (item.name == "13" || item.name == "29")
                    i++;
            }

            if (i == 2)
                giocatoreDiTurno.Paga(10 * int.Parse(GameObject.Find("Risultato Dadi").GetComponent<Text>().text));
            else
                giocatoreDiTurno.Paga(4 * int.Parse(GameObject.Find("Risultato Dadi").GetComponent<Text>().text));
        }
    }
}
