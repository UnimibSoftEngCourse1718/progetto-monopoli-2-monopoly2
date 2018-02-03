using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terreno : CasellaAcquistabile
{
    public int costo, ipoteca, costoEdificio, pedaggio, pedaggio1Casa, pedaggio2Case, pedaggio3Case, pedaggio4Case, pedaggioAlbergo, nEdifici = 0;
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
            if (nEdifici == 0)
            {
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggio);
                proprietario.TrasferimentoDenaro(pedaggio);
            }
            else if (nEdifici == 1)
            {
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggio1Casa);
                proprietario.TrasferimentoDenaro(pedaggio1Casa);
            }
            else if (nEdifici == 2)
            {
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggio2Case);
                proprietario.TrasferimentoDenaro(pedaggio2Case);
            }
            else if (nEdifici == 3)
            {
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggio3Case);
                proprietario.TrasferimentoDenaro(pedaggio3Case);
            }
            else if (nEdifici == 4)
            {
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggio4Case);
                proprietario.TrasferimentoDenaro(pedaggio4Case);
            }
            else if (nEdifici == 5)
            {
                giocatoreDiTurno.TrasferimentoDenaro(-pedaggioAlbergo);
                proprietario.TrasferimentoDenaro(pedaggioAlbergo);
            }
            giocatoreDiTurno.controller.Passa.interactable = true;
            giocatoreDiTurno.controller.Costruisci.interactable = true;
            giocatoreDiTurno.controller.AttivaTrattativa();
        }
    }

    public void CostruzioneEdificio()
    {
        float x = 0, z = 0;
        GameObject edificio = null;

        if (nEdifici == 0)
        {
            edificio = Instantiate(prefabCasa) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.17f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = 4;
            z = 7.8f;
            this.nEdifici++;
        }
        else if (nEdifici == 1)
        {
            edificio = Instantiate(prefabCasa) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.17f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = 2f;
            z = 7.8f;
            this.nEdifici++;
        }
        else if (nEdifici == 2)
        {
            edificio = Instantiate(prefabCasa) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.17f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = 0;
            z = 7.8f;
            this.nEdifici++;
        }
        else if (nEdifici == 3)
        {
            edificio = Instantiate(prefabCasa) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.17f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = -2;
            z = 7.8f;
            this.nEdifici++;
        }
        else if (nEdifici == 4)
        {
            RimuoviEdifici();
            edificio = Instantiate(prefabAlbergo) as GameObject;
            edificio.GetComponent<Transform>().localScale = new Vector3(0.33f, 0.28f, 0.25f);
            edificio.transform.position = this.transform.position;
            x = 3;
            z = 7.8f;
            this.nEdifici = 5;
        }

        edificio.transform.position = this.transform.position;
        edificio.GetComponent<Renderer>().material = proprietario.GetComponent<Renderer>().material;

        int i = int.Parse(this.name);
        if (i < 11)
        {
            edificio.transform.position += new Vector3(-x, 0, z);
        }
        else if (i < 21)
        {
            edificio.transform.position += new Vector3(z, 0, x);
            edificio.transform.Rotate(new Vector3(0, 90, 0));
        }
        else if (i < 31)
        {
            edificio.transform.position += new Vector3(x, 0, -z);
            edificio.transform.Rotate(new Vector3(0, 180, 0));
        }
        else
        {
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
