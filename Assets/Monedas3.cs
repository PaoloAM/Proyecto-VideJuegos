using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monedas3 : MonoBehaviour
{
    public AudioSource audioCoin;


    [SerializeField] private float cantidadPuntos;

    [SerializeField] private Puntaje puntaje;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
            audioCoin.Play();
            
        }
        if(other.gameObject.tag == "Player"){
            SceneManager.LoadScene(2);
        }
    }
    
}
