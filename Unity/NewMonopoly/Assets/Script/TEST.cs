using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {
    StateController controller;
	// Use this for initialization
	void Start () {
        controller = GameObject.FindObjectOfType<StateController>();
	}
	
	// Update is called once per frame
	void OnMouseUp () {
        controller.getGiocatoreAttivo().Bancarotta();
	}
}
