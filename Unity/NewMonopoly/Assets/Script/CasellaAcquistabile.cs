using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasellaAcquistabile : Casella {
    public giocatore proprietario { get; set; }
    protected GameObject segnalinoProprietario;
    public string nomeCasella;
    public SchermataAcquisto schermataAcquisto;

    public void CambioProprietario()
    {
        if (segnalinoProprietario != null)
        {
            Destroy(segnalinoProprietario);
        }
        
        if (proprietario != null)
        {

            if (this as Terreno != null)
            {
                Terreno terreno = this as Terreno;
                terreno.RimuoviEdifici();
            }

            segnalinoProprietario = GameObject.CreatePrimitive(PrimitiveType.Cube);
            segnalinoProprietario.GetComponent<Collider>().enabled = false;
            segnalinoProprietario.transform.position = this.transform.position;
            segnalinoProprietario.GetComponent<Renderer>().material = proprietario.GetComponent<Renderer>().material;

            int i = int.Parse(this.name);
            if (i < 11)
            {
                segnalinoProprietario.transform.localScale = new Vector3(8, 1, 2);
                segnalinoProprietario.transform.position += new Vector3(0, 0, -7);
            }
            else if (i < 21)
            {
                segnalinoProprietario.transform.localScale = new Vector3(2, 1, 8);
                segnalinoProprietario.transform.position += new Vector3(-7, 0, 0);
            }
            else if (i < 31)
            {
                segnalinoProprietario.transform.localScale = new Vector3(8, 1, 2);
                segnalinoProprietario.transform.position += new Vector3(0, 0, 7);
            }
            else
            {
                segnalinoProprietario.transform.localScale = new Vector3(2, 1, 8);
                segnalinoProprietario.transform.position += new Vector3(7, 0, 0);
            }
        }
    }
}
