using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetearDataRival : MonoBehaviour
{
    private Jugador jug;
    public TextMeshProUGUI nombre;
    public TextMeshProUGUI nickname;
    public TextMeshProUGUI apostador;
    public TextMeshProUGUI balance;
    public TextMeshProUGUI ganancias;


    private void Update()
    {
        jug= GetComponent<ModoVersus>().jugador2;
        nombre.text = jug.Nombre;
        nickname.text = jug.Nickname;
        apostador.text = jug.NumeroApostador.ToString();
        balance.text = jug.Balance.ToString();
        ganancias.text = jug.Ganancias.ToString();
    }
}
