using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contador : MonoBehaviour
{
    public TMP_Text textoTiempo;
    float acumulacion = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // actualizar el contaDOR DEL tiempo
        acumulacion = acumulacion + Time.deltaTime;
        Debug.Log(acumulacion);
        textoTiempo.text = ("Time" + acumulacion,0).ToString("#.00");
        // actualizar la interfaz




        // textoTiempo.text = "Hola iván :)";
        // Debug.Log("Hola iván :)");
    }
}
