using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoVersus : MonoBehaviour
{
    private GestorJugadores gestorJugadores;
    public Jugador jugador2;
    private void Start()
    {
        List<Jugador> gestorJugadores = GestorJugadores._instance.jugadores;
        jugador2 = SeleccionarJugadorAleatorioDiferente(GameManager._instance.JugadorActual);
        Debug.Log(jugador2.Nombre);
    }

    public void IniciarJuego(int apuesta)
    {
        // Obt�n el jugador actual, puedes hacerlo de la manera que tengas implementada en tu juego.
        Jugador jugadorActual = GameManager._instance.JugadorActual;

        // Aseg�rate de que haya jugadores disponibles antes de continuar.
        if (GestorJugadores._instance.jugadores.Count <= 1)
        {
            Debug.LogWarning("No hay suficientes jugadores disponibles para enfrentar.");
            return;
        }

        // Selecciona aleatoriamente al jugador 2 que sea diferente al jugador actual.
        

        int apuestar = Random.Range(1, 4);
        // Genera un n�mero aleatorio entre 1 y 3 para determinar la ganancia.
        int gananciaJugadorActual = Random.Range(1, 4);
        int gananciaJugador2 = Random.Range(1, 4);

        // Calcula las ganancias reales en monedas.
        int gananciaActual = gananciaJugadorActual * 10;
        int gananciaJugadorRival = gananciaJugador2 * 10;
        apuestar = apuesta * 10;
        
        gananciaActual -= gananciaJugadorActual - apuesta;
        gananciaJugadorRival = gananciaJugadorRival - apuestar;

        // Compara las ganancias para determinar el resultado.
        if (gananciaActual > gananciaJugadorRival)
        {
            Partida temp = new Partida(jugador2.Nombre, apuesta,apuestar, true, gananciaActual);
            Partida temp2 = new Partida(GameManager._instance.JugadorActual.Nombre, apuestar, apuesta, false, gananciaJugadorRival);
            jugadorActual.Partidas.Add(temp);
            jugador2.Partidas.Add(temp2);
            jugadorActual.Balance += apuesta;
            jugadorActual.Ganancias += apuesta;
            jugador2.Balance -= apuestar;
        }
        else if (gananciaJugadorRival > gananciaActual)
        {
            Partida temp = new Partida(jugador2.Nombre, apuesta, apuestar, false, gananciaActual);
            Partida temp2 = new Partida(GameManager._instance.JugadorActual.Nombre, apuestar, apuesta, true, gananciaJugadorRival);
            jugadorActual.Partidas.Add(temp);
            jugador2.Partidas.Add(temp2);
            jugadorActual.Balance -= apuesta;
            jugador2.Balance += apuesta;
            jugador2.Ganancias += apuesta;
        }
        else
        {
            bool ganadorAleatorio = Random.Range(0, 2) == 0; // 50% de probabilidad para cada jugador.
            if (ganadorAleatorio)
            {
                Partida temp = new Partida(jugador2.Nombre, apuesta, apuestar, true, gananciaActual);
                Partida temp2 = new Partida(GameManager._instance.JugadorActual.Nombre, apuestar, apuesta, false, gananciaJugadorRival);
                jugadorActual.Partidas.Add(temp);
                jugador2.Partidas.Add(temp2);
                jugadorActual.Balance += apuesta;
                jugadorActual.Ganancias += apuesta;
                jugador2.Balance -= apuestar;
            }
            else
            {
                Partida temp = new Partida(jugador2.Nombre, apuesta, apuestar, false, gananciaActual);
                Partida temp2 = new Partida(GameManager._instance.JugadorActual.Nombre, apuestar, apuesta, true, gananciaJugadorRival);
                jugadorActual.Partidas.Add(temp);
                jugador2.Partidas.Add(temp2);
                jugadorActual.Balance -= apuesta;
                jugador2.Balance += apuesta;
                jugador2.Ganancias += apuesta;
            }
        }

        // Actualiza la interfaz de usuario o realiza otras acciones seg�n el resultado.
    }

    private Jugador SeleccionarJugadorAleatorioDiferente(Jugador jugadorActual)
    {
        //temporal -> Real
         List<Jugador> jugadoresDisponibles = new List<Jugador> (GestorJugadores._instance.jugadores);
        jugadoresDisponibles.Remove(jugadorActual); // Remueve al jugador actual de la lista de opciones.

        // Selecciona aleatoriamente uno de los jugadores restantes.
        int indiceAleatorio = Random.Range(0, jugadoresDisponibles.Count);
        return jugadoresDisponibles[indiceAleatorio];
    }
}
