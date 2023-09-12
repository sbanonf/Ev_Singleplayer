using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    // Agrega tus propiedades y métodos necesarios aquí
    public Jugador JugadorActual { get; set; }


    private void Awake()
    {
        // Asegura que solo haya una instancia de GameManager
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject); // Mantén este objeto al cargar nuevas escenas
        }
        else
        {
            Destroy(gameObject); // Destruye duplicados
        }
    }

}
