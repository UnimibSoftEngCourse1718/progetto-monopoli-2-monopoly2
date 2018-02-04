using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giocatore : MonoBehaviour {

    Prigione prigione;
    public StateController controller { get; set; }

    public int PlayerId;
    public bool Attivo;

    public int soldi { get; set; }
    int soldiPrecedenti;
    float tempoAnimazioneSoldi;
    float durataAnimazioneSoldi = 10f;
    public Text testoSoldi;

    public List<CasellaAcquistabile> proprieta { get; set; }
    public Casella partenza { get; set; }

    Casella[] percorso;
    int indicePercorso;
    Vector3 targetPosition;
    Vector3 vettoreVelocita;
    float tempoPerSpostamento = 0.15f;
    bool arrivato;
    bool effettoCasella;

    public int contatorePrigione { get; set; }
    public bool uscitaDiPrigione { get; set; }

    void Start () {
        uscitaDiPrigione = false;
        contatorePrigione = -1;
        effettoCasella = true;
        proprieta = new List<CasellaAcquistabile>();
        soldi = 2500;
        soldiPrecedenti = 2500;
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
        if (Vector3.Distance(this.transform.position, targetPosition) < 1)
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
            }
        }
        this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref vettoreVelocita, tempoPerSpostamento);
        
        if (Mathf.Abs(soldiPrecedenti - soldi) > 10)
        {
            tempoAnimazioneSoldi += Time.deltaTime / durataAnimazioneSoldi;
            soldiPrecedenti = (int)Mathf.Lerp(soldiPrecedenti, soldi, tempoAnimazioneSoldi);
            this.testoSoldi.text = (soldiPrecedenti).ToString() + " $";
        }
        else
        {
            this.testoSoldi.text = (soldi).ToString() + " $";
            this.testoSoldi.color = Color.white;
        }
	}

    public void SetNewTargetPosition(Vector3 pos)
    {
        targetPosition = pos + new Vector3(-3, 0.1f, 0);
        vettoreVelocita = Vector3.zero;
    }

    private void OnMouseUp()
    {
        if (controller.CurrentPlayerId != PlayerId || controller.IsDoneClicking) return;

        controller.IsDoneClicking = true;

        if (controller.Doppio == 3)
        {
            controller.Doppio = 0;
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
            controller.Doppio = 0;
        }

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
        }
        if (this.contatorePrigione == -2)
            this.contatorePrigione = -1;

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
        if (importo > 0)
        {
            this.testoSoldi.color = Color.green;
        }
        else
        {
            this.testoSoldi.color = Color.red;
        }
        tempoAnimazioneSoldi = 0;
        soldiPrecedenti = soldi;
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
 