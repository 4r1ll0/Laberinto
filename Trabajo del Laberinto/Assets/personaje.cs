using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10f;
    float acumulacion = 0.0f;
    bool estoyQuieto = false;
    SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (estoyQuieto)
        {
            rb.velocity = new Vector2(0, 0);
            acumulacion = acumulacion + Time.deltaTime;
            Debug.Log(acumulacion);
            if (acumulacion > 5)
            {
                estoyQuieto = false;
                acumulacion = 0;
                sr.color = Color.yellow;
            }
        }
        else // me estoy moviendo
        {

          
            float movX = Input.GetAxis("Horizontal") * speed;
            float movY = Input.GetAxis("Vertical") * speed;
            rb.velocity = new Vector2(movX, movY);

        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("pared"));
        {
            sr.color = Color.red;
            //empezar cuenta atras
            estoyQuieto = true;
            //
        }
    }

}
