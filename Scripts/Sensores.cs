using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensores : MonoBehaviour {

    private Renderer rend;
    private bool activados;

	// Use this for initialization
	void Start () {
        SceneController.CambioSensores += Desactivar;
        rend = GetComponent<Renderer>();
        activados = true;
    }

    private void Desactivar()
    {
        activados = false;
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        if (activados)
            rend.material.color = Color.green;
    }

    private void OnCollisionStay(Collision other)
    {
        if (activados)
            rend.material.color = Color.yellow;
    }

    private void OnCollisionExit(Collision other)
    {
        if (activados)
            rend.material.color = Color.red;
    }
}
