using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esferas : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        SceneController.CambioEsferas += Saltar;
	}

    private void Saltar()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}
