using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class TemporizadorVS : MonoBehaviour
{
    // Variable para el tiempo total del temporizador (30 segundos en este caso)
    public float tiempoTotal = 30f;

    // Referencia al TextMeshProUGUI donde se mostrar� el tiempo restante
    public TextMeshProUGUI textoTiempoRestante;

    private void Start()
    {
        // Inicia la corutina para contar el tiempo
        StartCoroutine(ContarTiempo());
    }

    private IEnumerator ContarTiempo()
    {
        float tiempoTranscurrido = 0f;

        while (tiempoTranscurrido < tiempoTotal)
        {
            // Incrementa el tiempo transcurrido con respecto al tiempo real
            tiempoTranscurrido += Time.deltaTime;

            // Calcula el tiempo restante en segundos enteros
            int segundosRestantes = Mathf.FloorToInt(tiempoTotal - tiempoTranscurrido);

            // Actualiza el TextMeshProUGUI con el tiempo restante en segundos
            textoTiempoRestante.text = segundosRestantes.ToString();

            yield return null;
        }

        // Cuando se agoten los 30 segundos, ejecuta algo aqu�
        EjecutarAlgoAlTerminarTiempo();
    }

    private void EjecutarAlgoAlTerminarTiempo()
    {
        SceneManager.LoadScene("BadEnding");
    }
}
