using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contador : MonoBehaviour
{
    public TMP_Text textoTiempo;
    public TMP_Text textoContadorMonedas;
    float acumulacion = 0.0f;
 

    void Update()
    {
        // actualizar el contaDOR DEL tiempo
        acumulacion = acumulacion + Time.deltaTime;
        Debug.Log(acumulacion);
        textoTiempo.text = acumulacion.ToString("#.00");
        // actualizar la interfaz

        // textoTiempo.text = "Hola iván :)";
        // Debug.Log("Hola iván :)");
    }
}
