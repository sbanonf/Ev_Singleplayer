using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetearPartida : MonoBehaviour
{

    public TextMeshProUGUI nombreDePartidaText;
    public TextMeshProUGUI apuestayoText;
    public TextMeshProUGUI apuestariText;
    public TextMeshProUGUI victoriaText;
    public TextMeshProUGUI gananciaText;

    // Otros campos de TextMeshPro que desees configurar

    public void Configurar(Partida partida)
    {

        // Configura los valores de los campos de TextMeshPro con los datos de la partida
        nombreDePartidaText.text = partida.NombreRival; 
        apuestayoText.text = partida.ApuestaYo.ToString(); // Puedes formatearlos según tus necesidades
        apuestariText.text = partida.ApuestaRival.ToString();
        victoriaText.text = (partida.Victoria ? "Victoria" : "Derrota");
        gananciaText.text =  partida.Ganancia.ToString();
    }
}
