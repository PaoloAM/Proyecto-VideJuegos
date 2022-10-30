using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{   public Text cajaVida;
    public short vida=10000;
    public float velocidad=6.0f;
    public float salto=5.0f;
    Rigidbody2D rb2d;
    private bool saltando=false;
    // Start is called before the first frame update
    void Start()
    {   
        cajaVida.text = vida.ToString();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime,0, 0);
        if(Input.GetKey(KeyCode.Space) && !saltando){
   
            rb2d.AddForce(Vector2.up * salto);
           
        }
        Debug.Log(saltando);
    }    
    private void OnCollisionEnter2D(Collision2D obj){
        if(obj.collider.CompareTag("Plataforma")){
            saltando = false; 
        }

    }
    private void OnCollisionStay2D(Collision2D obj){
        Debug.Log("Mantengo la colision");
        if(obj.collider.CompareTag("Enemy")){
            vida--;
            cajaVida.text = vida.ToString();
        }
    }
        private void OnTriggerEnter2D(Collider2D obj){
        if(obj.CompareTag("PowerUp")){
            vida++;
            cajaVida.text = vida.ToString();
            
        } 
    }
    private void OnTriggerStay2D(Collider2D obj){
        if(obj.CompareTag("PowerUp")){
            vida++;
            cajaVida.text = vida.ToString();
        } 
    }
}





