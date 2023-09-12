using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorJugadores : MonoBehaviour
{
    public static GestorJugadores _instance;
    public List<Jugador> jugadores;

    // Puedes usar Awake o Start para inicializar la lista de jugadores.
    private void Awake()
    {
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