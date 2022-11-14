using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Puntaje : MonoBehaviour
{
  private float Puntos;
  private TextMeshProUGUI textMesh;


  private void Start()
  {
    textMesh = GetComponent<TextMeshProUGUI>();
  }

  private void Update()
  {
    Puntos += Time.deltaTime;
    textMesh.text = Puntos.ToString("0");
  }

  public void SumarPuntos(float puntosEntrada)
  {
    Puntos += puntosEntrada;
  }
}
