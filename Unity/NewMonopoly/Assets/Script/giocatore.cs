using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giocatore : MonoBehaviour {

    Prigione prigione;

    public int contatorePrigione;
    public bool uscitaDiPrigione { get; set; }
    public int soldi { get; set; }
    public Casella partenza { get; set; }
    public StateController controller { get; set; }
    public List<CasellaAcquistabile> proprieta;
    public Text testoSoldi;
    public int PlayerId;
    public bool attivo;
    public bool isAnimating, effettoCasella;
    Casella[] percorso;
    int indicePercorso;

    //istruzioni per animazione 
    Vector3 targetPosition;
    Vector3 vettoreVelocita;
    float tempoPerSpostamento;
    private bool arrivato;

    // Use this for initialization
    void Start () {
        uscitaDiPrigione = true;
        contatorePrigione = -1;
        effettoCasella = true;
        proprieta = new List<CasellaAcquistabile>();
        soldi = 2500;
        testoSoldi.text = this.soldi.ToString() + " $";
        targetPosition = this.transform.position;
        prigione = GameObject.FindObjectOfType<Prigione>();
        controller = GameObject.FindObjectOfType<StateController>();

        Casella[] caselle = GameObject.FindObjectsOfType<Casella>();
        foreach (Casella item in caselle)
        {
            if (item.name == "1")
            {
                partenza = item;
            }
        }
    }

	void Update ()
    {
        if (Vector3.Distance(this.transform.position, targetPosition) < 1f)
        {
            if (percorso != null && indicePercorso < percorso.Length)
            {
                this.SetNewTargetPosition(percorso[indicePercorso].transform.position);
                indicePercorso++;
            }
            else
            {
                this.isAnimating = false;
                if (!effettoCasella)
                {
                    effettoCasella = true;
                    partenza.Fermata(this);
                    controller.IsDoneClicking = true;
                }
            }
        }
        this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref vettoreVelocita, tempoPerSpostamento);
	}

    public void SetNewTargetPosition(Vector3 pos)
    {
        targetPosition = pos + new Vector3(-3, 0.1f, 0);
        vettoreVelocita = Vector3.zero;
    }

    private void OnMouseUp()
    {
        //controllo di chi è il turno e se ho già tirato
        if (controller.CurrentPlayerId != PlayerId || controller.IsDoneClicking == true) return;
        Casella arrivo = partenza;


        // Se è il terzo doppio tiro si finisce in prigione
        if (controller.doppio == 3)
        {
            controller.doppio = 0;
            this.contatorePrigione = 0;
            arrivo = Muovi(partenza, prigione);
        }
        else
        {
            arrivo = Muovi(controller.DiceTotal);
        }
        this.partenza = arrivo;
    }
    public Casella Muovi(int dado)
    {
        controller.IsDoneClicking = false;
        tempoPerSpostamento = controller.tempoPerSpostamento;
        effettoCasella = false;
        Casella arrivo = partenza;
        percorso = new Casella[dado];
        for (int i = 0; i < dado; i++)
        {
            arrivo = arrivo.prossimaCasella;
            percorso[i] = arrivo;
            if (percorso[i].name == "1" && this.contatorePrigione == -1)
            {
                this.Paga(-200);
            }
        }

        this.indicePercorso = 0;
        this.isAnimating = true;
        return arrivo;
    }

    public Casella Muovi(Casella partenza, Casella arrivo)
    {
        int numeroPartenza = int.Parse(partenza.name);
        int numeroArrivo = int.Parse(arrivo.name);
        if (numeroPartenza < numeroArrivo)
        {
            return Muovi(numeroArrivo - numeroPartenza);
        }
        else
        {
            return Muovi(40 + numeroArrivo - numeroPartenza);
        }
    }
    public void Paga(int importo)
    {
        this.soldi -= importo;
        this.testoSoldi.text = this.soldi.ToString() + " $";
        if (this.soldi < 0)
            this.Bancarotta();
    }

    public void Bancarotta()
    {
        controller.RimuoviGiocatore(this);
    }

    public void AggiungiProprieta(CasellaAcquistabile casella)
    {
        this.proprieta.Add(casella);
        casella.proprietario = this;
        casella.CambioProprietario();
    }

    public void RimuoviProprieta(CasellaAcquistabile casella)
    {
        this.proprieta.Remove(casella);
    }
}
 