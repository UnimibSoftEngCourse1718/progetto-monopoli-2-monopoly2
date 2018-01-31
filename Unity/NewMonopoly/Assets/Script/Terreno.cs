using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terreno : CasellaAcquistabile
{
    // Se si possiedono tutti i terreni di quel colore il pedaggio senza case si raddoppia
    // Se si possiedono tutti i terreni di quel colore è possibile costruire
    public int costo, ipoteca, costoEdificio, pedaggio, pedaggio1Casa, pedaggio2Case, pedaggio3Case, pedaggio4Case, pedaggioAlbergo, nEdifici;
    GameObject edificio;

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

    public void CostruzioneEdificio()
    {
        this.nEdifici += 1;

        edificio = GameObject.CreatePrimitive(PrimitiveType.Cube);
        edificio.GetComponent<Collider>().enabled = false;
        edificio.transform.position = this.transform.position;
        edificio.GetComponent<Renderer>().material = proprietario.GetComponent<Renderer>().material;

        int i = int.Parse(this.name);
        if (i < 11)
        {
            // caselle sotto
            edificio.transform.localScale = new Vector3(8, 1, 2);
            edificio.transform.position += new Vector3(0, 0, 7);
        }
        else if (i < 21)
        {
            // caselle sinistra
            edificio.transform.localScale = new Vector3(2, 1, 8);
            edificio.transform.position += new Vector3(7, 0, 0);
        }
        else if (i < 31)
        {
            // caselle sopra
            edificio.transform.localScale = new Vector3(8, 1, 2);
            edificio.transform.position += new Vector3(0, 0, -7);
        }
        else
        {
            // caselle destra
            edificio.transform.localScale = new Vector3(2, 1, 8);
            edificio.transform.position += new Vector3(-7, 0, 0);
        }
    }
}
