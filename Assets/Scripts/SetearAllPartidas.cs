using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetearAllPartidas : MonoBehaviour
{
    public Transform contenedorDePartidas; // El objeto contenedor donde se instanciar�n las partidas
    public GameObject prefabDePartida; // El prefab de la partida

    // Esta funci�n se llama para configurar las partidas
    public void ConfigurarPartidas(List<Partida> partidas)
    {
        foreach (Partida partida in partidas)
        {
            // Instancia el prefab de la partida
            GameObject nuevaPartida = Instantiate(prefabDePartida, contenedorDePartidas);

            // Obt�n el componente "ConfigurarPartida" del prefab de la partida
            SetearPartida configurador = nuevaPartida.GetComponent<SetearPartida>();

            // Configura los valores de los campos de TextMeshPro en funci�n de la partida
            configurador.Configurar(partida);
        }
    }
    private void Start()
    {
        ConfigurarPartidas(GameManager._instance.JugadorActual.Partidas);
    }
}
