using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giocatore : MonoBehaviour {

    Prigione prigione;
    public List<Casella> proprieta;
    public int contatorePrigione;
    public bool uscitaDiPrigione;
    public int soldi;
    public StateController controller;
    bool isAnimating;
    public int PlayerId;
    public Casella partenza;

    //istruzioni per animazione 
    Vector3 targetPosition;
    Vector3 velocity;
    float smoothTime = 0.5f;

    // Use this for initialization
    void Start () {
        proprieta = new List<Casella>();
        soldi = 2000;
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

	// Update is called once per frame, aggiungo l'animazione
	void Update () {
        if (this.transform.position != targetPosition)
            this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref velocity, smoothTime);		
	}

    public void SetNewTargetPosition(Vector3 pos)
    {
        targetPosition = pos + new Vector3(0, 1, 0);
        velocity = Vector3.zero;
    }

    private void OnMouseUp()
    {
        if (controller.doppio == 3)
        {
            this.contatorePrigione = 0;
            this.SetNewTargetPosition(prigione.transform.position);
            this.partenza = prigione;
        }

        int spazio = int.Parse(GameObject.Find("Risultato Dadi").GetComponent<Text>().text);

        //controllo di chi è il turno 
        if (controller.CurrentPlayerId != PlayerId) return;

        if (controller.IsDoneClicking == true) return; // ho già tirato , mo basta

        Casella arrivo = partenza;
        for (int i = 0; i < spazio; i++)
        {
            if (partenza == null) arrivo = partenza;
            else
            {
                arrivo = arrivo.prossimaCasella;
            }
        }
        if (arrivo == null) return;

        controller.IsDoneClicking = true;
        this.isAnimating = true;
        SetNewTargetPosition(arrivo.transform.position);
        partenza = arrivo;
        arrivo.Fermata(this);
    }

    public void Paga(int importo)
    {
        if (soldi < importo) Bancarotta();
        soldi = soldi - importo;
    }

    public void Bancarotta()
    {
        DestroyImmediate(this);
    }

    public void Acquisto(CasellaAcquistabile casella)
    {
        proprieta.Add(casella);
        casella.proprietario = this;
    }

    public void Vendita(CasellaAcquistabile casella)
    {
        proprieta.Remove(casella);
    }
}
 