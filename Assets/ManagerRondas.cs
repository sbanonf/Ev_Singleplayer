using UnityEngine;
using System;

public class ManagerRondas : MonoBehaviour
{
    // Variable estática para acceder al Singleton
    public static ManagerRondas instance;

    // Variable para llevar la cuenta de las rondas
    public int rondas = 0;

    // Evento que se activa cuando se alcanzan las 10 rondas
    public event Action On10RondasReached;

    private void Awake()
    {
        // Configura el Singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Función para adicionar una ronda
    public void AdicionarRonda()
    {
        rondas++;

        // Verifica si se llega a 10 rondas
        if (rondas == 10)
        {
            // Activa el evento
            On10RondasReached?.Invoke();
        }
        // Verifica si se llega a 20 rondas
        else if (rondas == 20)
        {
            EjecutarOtraCosaPara20Rondas();
        }
    }

    private void EjecutarOtraCosaPara20Rondas()
    {
        
    }

    // Resto del código...
}