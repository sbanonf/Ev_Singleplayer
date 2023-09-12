using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetearLobby : MonoBehaviour
{
    public TextMeshProUGUI nombre;
    public TextMeshProUGUI nickname;
    public TextMeshProUGUI apostador;
    public TextMeshProUGUI balance;
    public TextMeshProUGUI ganancias;

    private void Start()
    {
        var jugador = GameManager._instance.JugadorActual;
        nombre.text = jugador.Nombre;
        nickname.text = jugador.Nickname;
        apostador.text = "apostador: "+jugador.NumeroApostador.ToString();
        balance.text = jugador.Balance.ToString();
        ganancias.text = jugador.Ganancias.ToString();
    }
}
