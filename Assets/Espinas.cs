using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinas : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;

    private float tiempoSiguienteDaño;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if(tiempoSiguienteDaño <= 0)
            {
            other.GetComponent<NewBehaviourScript>().TomarDaño(30);
            tiempoSiguienteDaño = tiempoEntreDaño;
            }
            
        }
    }

    private void OnTriggerStay2D(Collider2D other){
        if(other.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if(tiempoSiguienteDaño <= 0)
            {
            other.GetComponent<NewBehaviourScript>().TomarDaño(30);
            tiempoSiguienteDaño = tiempoEntreDaño;
            }
            
        }
    }
}
