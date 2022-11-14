using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad=6.0f;
    public float salto=5.0f;
    Rigidbody2D rb2d;
    private bool saltando=false;
   
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
         transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime,0, 0);
        if(Input.GetKey(KeyCode.Space) && !saltando){
   
            rb2d.AddForce(Vector2.up * salto);
           
        }
    }

     private void OnCollisionEnter2D(Collision2D obj)
    {
        if(obj.collider.CompareTag("Plataforma")){
            saltando = false; 
        }

    }
}
