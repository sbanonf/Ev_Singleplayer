using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public TMP_InputField nombreInputField;
    public TMP_InputField apellidoInputField;
    public Button iniciarJuegoButton;

    private void Start()
    {
        iniciarJuegoButton.onClick.AddListener(IniciarJuego);
    }

    private void IniciarJuego()
    {
        string nombre = nombreInputField.text;
        string apellido = apellidoInputField.text;

        if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
        {
            string nickname = nombre + " " + apellido;
            CrearNuevoJugador(nickname);
        }
        else
        {
            Debug.Log("Por favor, completa ambos campos de entrada.");
        }
    }

    private void CrearNuevoJugador(string nickname)
    {
        GameManager._instance.JugadorActual = new Jugador(nombreInputField.text, nickname, 1);
        GestorJugadores._instance.jugadores.Add(GameManager._instance.JugadorActual);
        Jugador temp = new Jugador("Pepito", "Pepito perez", 2);
        Partida temp2 = new Partida(temp.Nombre, 20, 30, true, 30);
        GameManager._instance.JugadorActual.Partidas.Add(temp2);
        Jugador Perez = new("Perez", "Perez Diaz", 3);
        Jugador Sam = new("Sam", "Sam Paloma", 4);
        Jugador John = new("John", "John Delgado", 5);
        GestorJugadores._instance.jugadores.Add(Perez);
        GestorJugadores._instance.jugadores.Add(Sam);
        GestorJugadores._instance.jugadores.Add(John);
        SceneManager.LoadScene("MainGame");

    }
}

