using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terreno : CasellaAcquistabile
{
    // Se si possiedono tutti i terreni di quel colore il pedaggio senza case si raddoppia
    // Se si possiedono tutti i terreni di quel colore è possibile costruire
    public int costo, ipoteca, costoEdificio, pedaggio, pedaggio1Casa, pedaggio2Case, pedaggio3Case, pedaggio4Case, pedaggioAlbergo, nEdifici;

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (proprietario == null)
        {
            schermataAcquisto.terreno = this;
            schermataAcquisto.OnEnable();
        }
        else
        {
            // Terreno occupato // Pedaggio
            if (nEdifici == 0)
            {
                giocatoreDiTurno.Paga(pedaggio);
                proprietario.Paga(-pedaggio);
            }
            else if (nEdifici == 1)
            {
                giocatoreDiTurno.Paga(pedaggio1Casa);
                proprietario.Paga(-pedaggio1Casa);
            }
            else if (nEdifici == 2)
            {
                giocatoreDiTurno.Paga(pedaggio2Case);
                proprietario.Paga(-pedaggio2Case);
            }
            else if (nEdifici == 3)
            {
                giocatoreDiTurno.Paga(pedaggio3Case);
                proprietario.Paga(-pedaggio3Case);
            }
            else if (nEdifici == 4)
            {
                giocatoreDiTurno.Paga(pedaggio4Case);
                proprietario.Paga(-pedaggio4Case);
            }
            else if (nEdifici == 5)
            {
                giocatoreDiTurno.Paga(pedaggioAlbergo);
                proprietario.Paga(-pedaggioAlbergo);
            }
        }
        return;
    }
}
