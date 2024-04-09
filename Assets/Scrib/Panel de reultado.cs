using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paneldereultado : MonoBehaviour
{
    public GameObject PanelResultado;
    private void Start()
    {
        
    }
    public void MostrarPanelDeResultado()
    {
        if (PanelResultado != null)
        {
            PanelResultado.SetActive(true); // Activa el panel de resultados
            Time.timeScale = 0f; // Pausa el juego al mostrar el panel de resultados
        }
        else
        {
            Debug.LogWarning("Panel de resultados no asignado en el GameManager.");
        }
    }

}
