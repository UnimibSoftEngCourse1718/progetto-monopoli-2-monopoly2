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
    public bool effettoCasella;
    Casella[] percorso;
    int indicePercorso;

    Vector3 targetPosition;
    Vector3 vettoreVelocita;
    float tempoPerSpostamento;
    private bool arrivato;

    void Start () {
        uscitaDiPrigione = false;
        contatorePrigione = -1;
        effettoCasella = true;
        proprieta = new List<CasellaAcquistabile>();
        soldi = 1000;
        testoSoldi.text = this.soldi.ToString() + " $";
        targetPosition = this.transform.position;
        prigione = GameObject.FindObjectOfType<Prigione>();
        controller = GameObject.FindObjectOfType<StateController>();

        foreach (Casella item in GameObject.FindObjectsOfType<Casella>())
            if (item.name == "1")
                partenza = item;

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
            else if (!effettoCasella)
            {
                effettoCasella = true;
                partenza.Fermata(this);
                controller.IsDoneClicking = true;
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
        if (controller.CurrentPlayerId != PlayerId || controller.IsDoneClicking == true) return;

        if (controller.doppio == 3)
        {
            controller.doppio = 0;
            this.contatorePrigione = 0;
            this.partenza = Muovi(partenza, prigione);
        }
        else
        {
            this.partenza = Muovi(controller.DiceTotal);
        }
    }
    public Casella Muovi(int dado)
    {
        if (this.contatorePrigione != -1)
        {
            controller.doppio = 0;
        }
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
                this.TrasferimentoDenaro(200);
            }
            if (this.contatorePrigione == -2)
                this.contatorePrigione = -1;
        }

        this.indicePercorso = 0;
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

    public void TrasferimentoDenaro(int importo)
    {
        this.soldi += importo;
        this.testoSoldi.text = this.soldi.ToString() + " $";
        if (this.soldi < 0)
        {
            this.Bancarotta();
        }
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
        casella.CambioProprietario();
        this.proprieta.Remove(casella);
    }
}
 