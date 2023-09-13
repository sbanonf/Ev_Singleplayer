using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetTramposos : MonoBehaviour
{
    public Transform contenedorDePartidas; // El objeto contenedor donde se instanciarán las partidas
    public GameObject prefabDePartida; // El prefab de la partida

    // Esta función se llama para configurar las partidas
    public void ConfigurarPartidas(List<Jugador> jugadores)
    {
        foreach (Jugador jugador in jugadores)
        {
            // Instancia el prefab de la partida
            GameObject nuevoJugador = Instantiate(prefabDePartida, contenedorDePartidas);
            SetearJugador configurador = nuevoJugador.GetComponent<SetearJugador>();
            configurador.Configurar(jugador);
        }
    }
    private void Start()
    {
        Debug.Log(GestorJugadores._instance.jugadores);
        ConfigurarPartidas(GestorJugadores._instance.jugadores);
    }
}


