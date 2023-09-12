using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetearData : MonoBehaviour
{
    public TextMeshProUGUI nombre;
    public TextMeshProUGUI nickname;
    public TextMeshProUGUI apostador;

    private void Start()
    {
        nombre.text = GameManager._instance.JugadorActual.Nombre;
        nickname.text = GameManager._instance.JugadorActual.Nickname;
        apostador.text ="apostador: "+ GameManager._instance.JugadorActual.NumeroApostador.ToString();
 
    }
}
