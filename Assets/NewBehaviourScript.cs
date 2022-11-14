using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{  
    
    

    [SerializeField] private float vida;

    [SerializeField] private float maximoVida;

    [SerializeField]private BarraDeVida barradeVida;


    private void Start()
    {   
        vida = maximoVida;
        barradeVida.InicializarBarraDeVida(vida);
    }

    

    public void TomarDaño(int daño)
    {
        vida -= daño;
        barradeVida.CambiarVidaActual(vida);
        if(vida <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(3);
        }
    }

    public void Curar (int curacion)
    {
        barradeVida.CambiarVidaActual(vida);
        if ((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }
        else
        {
            vida += curacion;
        }
    }
   
}





