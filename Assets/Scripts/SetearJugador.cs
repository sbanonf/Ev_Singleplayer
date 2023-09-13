using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetearJugador : MonoBehaviour
{
    public TextMeshProUGUI nombrejugador;
    public TextMeshProUGUI napostador;
    public TextMeshProUGUI balance;
    public TextMeshProUGUI tramposo;


    // Otros campos de TextMeshPro que desees configurar

    public void Configurar(Jugador jug)
    {
        nombrejugador.text = jug.Nombre;
        napostador.text = "apostador: " + jug.NumeroApostador.ToString();
        balance.text = jug.Balance.ToString();
        tramposo.text = (jug.tramposo == true ? "Tramposo" : "Inocente");
    }

}