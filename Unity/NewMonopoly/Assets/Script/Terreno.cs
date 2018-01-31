using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terreno : CasellaAcquistabile
{
    // Se si possiedono tutti i terreni di quel colore il pedaggio senza case si raddoppia
    // Se si possiedono tutti i terreni di quel colore è possibile costruire
    public int costo, ipoteca, costoEdificio, pedaggio, pedaggio1Casa, pedaggio2Case, pedaggio3Case, pedaggio4Case, pedaggioAlbergo, nEdifici;
    public GameObject prefabCasa, prefabAlbergo;
    List<GameObject> edifici = new List<GameObject>();

    public override void Fermata(giocatore giocatoreDiTurno)
    {
        if (proprietario == null)
        {
            schermataAcquisto.terreno = this;
            schermataAcquisto.Visualizza();
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
        float x = 0, z = 0;
        GameObject edificio = null;

        if (nEdifici == 1)
        {
            edificio = Instantiate(prefabCasa) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.17f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = 4;
            z = 7.8f;
        }
        else if (nEdifici == 2)
        {
            edificio = Instantiate(prefabCasa) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.17f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = 2f;
            z = 7.8f;
        }
        else if (nEdifici == 3)
        {
            edificio = Instantiate(prefabCasa) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.17f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = 0;
            z = 7.8f;
        }
        else if (nEdifici == 4)
        {
            edificio = Instantiate(prefabCasa) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.17f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = -2;
            z = 7.8f;
        }
        else if (nEdifici == 5)
        {
            // Rimuovo le case prima di mettere l'albergo, pazienza per le famiglie
            RimuoviEdifici();

            edificio = Instantiate(prefabAlbergo) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.33f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = 3;
            z = 7.8f;
        }

        edificio.transform.position = this.transform.position;
        edificio.GetComponent<Renderer>().material = proprietario.GetComponent<Renderer>().material;

        int i = int.Parse(this.name);
        if (i < 11)
        {
            // caselle sotto
            edificio.transform.position += new Vector3(-x, 0, z);
        }
        else if (i < 21)
        {
            // caselle sinistra
            edificio.transform.position += new Vector3(z, 0, x);
            edificio.transform.Rotate(new Vector3(0, 90, 0));
        }
        else if (i < 31)
        {
            // caselle sopra
            edificio.transform.position += new Vector3(x, 0, -z);
            edificio.transform.Rotate(new Vector3(0, 180, 0));
        }
        else
        {
            // caselle destra
            edificio.transform.position += new Vector3(-z, 0, -x);
            edificio.transform.Rotate(new Vector3(0, -90, 0));
        }

        edifici.Add(edificio);
        edificio = null;
    }

    public void RimuoviEdifici()
    {
        foreach (GameObject item in edifici)
            DestroyImmediate(item);
        edifici.Clear();
        this.nEdifici = 0;
    }
}
