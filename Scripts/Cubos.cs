using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour {

    private Renderer rend;

    // Use this for initialization
    void Start () {
        SceneController.CambioCubos += CambiarColor;
    }

    private void CambiarColor()
    {
        rend = GetComponent<Renderer>();
        if (rend.material.color == Color.green)
            rend.material.color = Color.blue;
        else
            rend.material.color = Color.green;
    }
}
