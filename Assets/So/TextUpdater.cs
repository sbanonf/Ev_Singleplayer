using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TextUpdater : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public TextData textData;

    private void Start()
    {
        textData.currentIndex = 0;
        UpdateText();
    }

    private void Update()
    {
        // Verifica si se ha presionado cualquier tecla.
        if (Input.GetMouseButtonDown(1))
        {
            AudioManager.instance.Play("press");
            NextText();
        }
    }

    private void UpdateText()
    {
        if (textData.currentIndex < textData.textArray.Length)
        {
            textMesh.text = textData.textArray[textData.currentIndex];
        }
    }

    // Llama a esta función para avanzar al siguiente elemento del array.
    public void NextText()
    {
        if (textData.currentIndex < textData.textArray.Length - 1)
        {
            textData.currentIndex++;
            UpdateText();
        }
        else {
            SceneManager.LoadScene("Lobby");
        }
    }

    // Llama a esta función para retroceder al elemento anterior del array.
    public void PreviousText()
    {
        if (textData.currentIndex > 0)
        {
            textData.currentIndex--;
            UpdateText();
        }
    }
}
