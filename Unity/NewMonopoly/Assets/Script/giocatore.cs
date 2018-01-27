﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Giocatore : MonoBehaviour {

    public Casella[] territori;
    public int contatorePrigione;
    public bool uscitaDiPrigione;
    public int soldi;

	// Use this for initialization
	void Start () {
        //int numero = int.Parse(GameObject.Find("Risultato Dadi").GetComponent<Text>().text);
        targetPosition = this.transform.position;
      }

    public Casella partenza;

    //istruzioni per animazione 
    Vector3 targetPosition;
    Vector3 velocity;
    float smoothTime = 1f;

	
	// Update is called once per frame, aggiungo l'animazione
	void Update () {
        if (this.transform.position != targetPosition)
            this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPosition, ref velocity, smoothTime);		
	}


    void SetNewTargetPosition(Vector3 pos)
    {

        targetPosition = pos;
        velocity = Vector3.zero;
    }

     private void OnMouseUp()
    {
        int spazio = int.Parse(GameObject.Find("Risultato Dadi").GetComponent<Text>().text);
       
        Casella arrivo = partenza;
        for(int i = 0; i < spazio; i++)
        {

            if (partenza == null) arrivo = partenza;

            else
            {
                arrivo = arrivo.prossimaCasella;
                Debug.Log(arrivo.prossimaCasella);
            }
            }
        if (arrivo == null) return;

        SetNewTargetPosition(arrivo.transform.position);
        partenza = arrivo;
    }

}
