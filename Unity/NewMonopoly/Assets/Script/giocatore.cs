using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giocatore : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
        controllore = GameObject.FindObjectOfType<StateController>();

        targetPosition = this.transform.position;
    }

    public RANDOM tiro;

    public Casella casellaDiPartenza;
    Casella casellaCorrente;

    bool scoreMe = false;

    public StateController controllore;

    Casella[] moveQueue;
    int moveQueueIndex;

    bool isAnimating = false;

    Vector3 targetPosition;
    Vector3 velocity;
    float smoothTime = 0.25f;
    float smoothTimeVertical = 0.1f;
    float smoothDistance = 0.01f;
    float smoothHeight = 0.5f;

    // Update is called once per frame
    void Update()
    {

        if (isAnimating == false)
        {
            
            return;
        }

        if (Vector3.Distance(
               new Vector3(this.transform.position.x, targetPosition.y, this.transform.position.z),
               targetPosition) < smoothDistance)
        {
            
            if (moveQueue != null && moveQueueIndex == (moveQueue.Length) && this.transform.position.y > smoothDistance)
            {
                this.transform.position = Vector3.SmoothDamp(
                    this.transform.position,
                    new Vector3(this.transform.position.x, 0, this.transform.position.z),
                    ref velocity,
                    smoothTimeVertical);
            }
            else
            {
                
                AdvanceMoveQueue();
            }
        }
        else if (this.transform.position.y < (smoothHeight - smoothDistance))
        {
            
            this.transform.position = Vector3.SmoothDamp(
                this.transform.position,
                new Vector3(this.transform.position.x, smoothHeight, this.transform.position.z),
                ref velocity,
                smoothTimeVertical);
        }
        else
        {
            this.transform.position = Vector3.SmoothDamp(
                this.transform.position,
                new Vector3(targetPosition.x, smoothHeight, targetPosition.z),
                ref velocity,
                smoothTime);
        }

    }

    void AdvanceMoveQueue()
    {
        if (moveQueue != null && moveQueueIndex < moveQueue.Length)
        {
            Casella prossimaCasella = moveQueue[moveQueueIndex];


        }
        else
        {
            
            Debug.Log("Done animating!");
            this.isAnimating = false;
            controllore.IsDoneAnimating = true;
        }

    }

    void SetNewTargetPosition(Vector3 pos)
    {
        targetPosition = pos;
        velocity = Vector3.zero;
    }

    void RollDice()
    {

        int spacesToMove = tiro.risultato;

        moveQueue = new Casella[spacesToMove];
        Casella casellaFinale = casellaDiPartenza;

        for (int i = 0; i < spacesToMove; i++)
        {
            casellaFinale = casellaFinale.prossimaCasella;
            //if casellaFinale == casellaVia +200
            moveQueue[i] = casellaFinale;
        }

        moveQueueIndex = 0;
        casellaDiPartenza = casellaFinale;
        this.isAnimating = true;
    }
}