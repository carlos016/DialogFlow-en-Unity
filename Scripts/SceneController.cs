using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public delegate void PlayerEvents();
    public static event PlayerEvents CambioSensores;
    public static event PlayerEvents CambioEsferas;
    public static event PlayerEvents CambioCubos;

    public static void DesactivarSensores()
    {
        if (CambioSensores != null)
        {
            CambioSensores();
        }
    }

    public static void SaltoEsferas()
    {
        if (CambioEsferas != null)
        {
            CambioEsferas();
        }
    }

    public static void CambioColor()
    {
        if (CambioCubos != null)
        {
            CambioCubos();
        }
    }
}
