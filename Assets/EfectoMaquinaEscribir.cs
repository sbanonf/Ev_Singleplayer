using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EfectoMaquinaEscribir : MonoBehaviour
{
    public TextMeshProUGUI textoMesh;
    public string textoCompleto;
    public float velocidadEscritura = 0.1f; // Velocidad de escritura en segundos por carácter

    private bool escrituraCompleta = false;

    private void Start()
    {
        // Inicia la corutina para el efecto de máquina de escribir
        StartCoroutine(EfectoMaquinaEscribirTexto());
    }

    private IEnumerator EfectoMaquinaEscribirTexto()
    {
        textoMesh.text = ""; // Inicializa el texto vacío

        for (int i = 0; i < textoCompleto.Length; i++)
        {
            // Agrega el siguiente carácter al texto
            textoMesh.text += textoCompleto[i];

            // Espera un tiempo antes de agregar el siguiente carácter
            yield return new WaitForSeconds(velocidadEscritura);
        }

        escrituraCompleta = true;
    }

    // Puedes llamar a esta función para completar instantáneamente el efecto
    public void CompletarEscritura()
    {
        if (!escrituraCompleta)
        {
            StopAllCoroutines(); // Detiene la corutina actual
            textoMesh.text = textoCompleto; // Establece el texto completo de inmediato
            escrituraCompleta = true;
        }
    }
}

