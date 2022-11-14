using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regenerar : MonoBehaviour
{
    public AudioSource Curacion;


   

   private void OnTriggerStay2D(Collider2D other){
    if(other.CompareTag("Player")){
        other.GetComponent<NewBehaviourScript>().Curar(5);
        
        Curacion.Play();
        if(other.CompareTag("PowerUp")){
            other.GetComponent<BarraDeVida>().CambiarVidaMaxima(5);
            
        }
    }
   }
   private void OnTriggerExit2D(Collider2D other){
    if(other.CompareTag("PowerUp")){
        Curacion.Stop();
    }
   }
}
