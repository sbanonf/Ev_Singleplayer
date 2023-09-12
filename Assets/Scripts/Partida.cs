using UnityEngine;

public class Partida 
{
    public string NombreRival { get; set; }
    public float ApuestaYo { get; set; }
    
    public float ApuestaRival { get; set; }
    public bool Victoria { get; set; }

    public float Ganancia { get; set; }

    public Partida(string nombrePartida, float apuesta, float apuestarival, bool victoria, float ganancia)
    {
        NombreRival = nombrePartida;
        ApuestaYo = apuesta;
        ApuestaRival = apuestarival;
        Victoria = victoria;
        Ganancia = ganancia;
    }
}