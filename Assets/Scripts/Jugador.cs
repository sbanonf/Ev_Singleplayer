using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jugador 
{
    public string Nombre { get; set; }
    public string Nickname { get; set; }
    public int NumeroApostador { get; set; }
    public float Balance { get; set; }
    public float Ganancias { get; set; }
    public List<Partida> Partidas { get; set; }

    private void Start()
    {
        GameManager._instance.JugadorActual = new Jugador("Nombre", "Nickname", 1);
    }

    public Jugador(string nombre, string nickname, int numeroApostador)
    {
        Nombre = nombre;
        Nickname = nickname;
        NumeroApostador = numeroApostador;
        Balance = 100; // Inicializa el saldo en 0
        Ganancias = 0; // Inicializa las ganancias en 0
        Partidas = new List<Partida>();
    }
}
