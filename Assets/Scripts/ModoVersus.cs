using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoVersus : MonoBehaviour
{
    private GestorJugadores gestorJugadores;
    public SetearGanador _setearGanador;
    public Jugador jugador2;
    public Canvas ganador;
    private void Start()
    {
        List<Jugador> gestorJugadores = GestorJugadores._instance.jugadores;
        jugador2 = SeleccionarJugadorAleatorioDiferente(GameManager._instance.JugadorActual);
        Debug.Log(jugador2.Nombre);
    }

    public void IniciarJuego(int apuesta)
    {
        AudioManager.instance.Play("press");

        // Obtén el jugador actual, puedes hacerlo de la manera que tengas implementada en tu juego.
        Jugador jugadorActual = GameManager._instance.JugadorActual;

        // Asegúrate de que haya jugadores disponibles antes de continuar.
        if (GestorJugadores._instance.jugadores.Count <= 1)
        {
            Debug.LogWarning("No hay suficientes jugadores disponibles para enfrentar.");
            return;
        }

        // Selecciona aleatoriamente al jugador 2 que sea diferente al jugador actual.
        

        int apuestar = Random.Range(1, 4);
        // Genera un número aleatorio entre 1 y 3 para determinar la ganancia.
        int gananciaJugadorActual = Random.Range(1, 4);
        int gananciaJugador2 = Random.Range(1, 4);

        // Calcula las ganancias reales en monedas.
        int gananciaActual = gananciaJugadorActual * 10;
        int gananciaJugadorRival = gananciaJugador2 * 10;
        apuestar = apuestar * 10;
        
        gananciaActual = gananciaActual - apuesta;
        gananciaJugadorRival = gananciaJugadorRival - apuestar;
        if (!GameManager._instance.JugadorActual.tramposo) {
            // Compara las ganancias para determinar el resultado.
            if (apuesta > apuestar)
            {
                Partida temp = new Partida(jugador2.Nombre, apuesta, apuestar, true, gananciaActual);
                Partida temp2 = new Partida(GameManager._instance.JugadorActual.Nombre, apuestar, apuesta, false, gananciaJugadorRival);
                jugadorActual.Partidas.Add(temp);
                jugador2.Partidas.Add(temp2);
                jugadorActual.Balance += apuesta;
                jugadorActual.Ganancias += gananciaActual;
                jugador2.Balance -= apuestar;
                _setearGanador.SetearTextos(gananciaActual.ToString(), apuesta.ToString(), apuestar.ToString(), jugador2.Nombre, "Ganaste", jugadorActual.Balance.ToString());
                ganador.gameObject.SetActive(true);
            }
            else if (apuestar > apuesta)
            {
                Partida temp = new Partida(jugador2.Nombre, apuesta, apuestar, false, gananciaActual);
                Partida temp2 = new Partida(GameManager._instance.JugadorActual.Nombre, apuestar, apuesta, true, gananciaJugadorRival);
                jugadorActual.Partidas.Add(temp);
                jugador2.Partidas.Add(temp2);
                jugadorActual.Balance -= apuesta;
                jugador2.Balance += apuesta;
                jugador2.Ganancias += gananciaJugadorRival;
                _setearGanador.SetearTextos(gananciaActual.ToString(), apuesta.ToString(), apuestar.ToString(), jugador2.Nombre, "Perdiste", jugadorActual.Balance.ToString());
                ganador.gameObject.SetActive(true);



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
                    jugadorActual.Ganancias += gananciaActual;
                    jugador2.Balance -= apuestar;
                    _setearGanador.SetearTextos(gananciaActual.ToString(), apuesta.ToString(), apuestar.ToString(), jugador2.Nombre, "Ganaste", jugadorActual.Balance.ToString());
                    ganador.gameObject.SetActive(true);
                

                }
                else
                {
                    Partida temp = new Partida(jugador2.Nombre, apuesta, apuestar, false, gananciaActual);
                    Partida temp2 = new Partida(GameManager._instance.JugadorActual.Nombre, apuestar, apuesta, true, gananciaJugadorRival);
                    jugadorActual.Partidas.Add(temp);
                    jugador2.Partidas.Add(temp2);
                    jugadorActual.Balance -= apuesta;
                    jugador2.Balance += apuesta;
                    jugador2.Ganancias += gananciaJugadorRival;
                    _setearGanador.SetearTextos(gananciaActual.ToString(), apuesta.ToString(), apuestar.ToString(), jugador2.Nombre, "Perdiste", jugadorActual.Balance.ToString());
                    ganador.gameObject.SetActive(true);
 
                }
            }

        }
        else
        {
            Partida temp = new Partida(jugador2.Nombre, apuesta, apuestar, true, gananciaActual);
            Partida temp2 = new Partida(GameManager._instance.JugadorActual.Nombre, apuestar, apuesta, false, gananciaJugadorRival);
            jugadorActual.Partidas.Add(temp);
            jugador2.Partidas.Add(temp2);
            jugadorActual.Balance += apuesta;
            jugadorActual.Ganancias += apuesta;
            jugador2.Balance -= apuestar;
            _setearGanador.SetearTextos(gananciaActual.ToString(), apuesta.ToString(), apuestar.ToString(), jugador2.Nombre, "Ganaste", jugadorActual.Balance.ToString());
            ganador.gameObject.SetActive(true);

            GameManager._instance.JugadorActual.tramposo = true;
        }

        // Actualiza la interfaz de usuario o realiza otras acciones según el resultado.
    }

    public void SetTramposo() {
        GameManager._instance.JugadorActual.tramposo = true;
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
