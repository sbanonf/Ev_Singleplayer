using UnityEngine;

public class ActivadorObjetos : MonoBehaviour
{
    public GameObject objeto1;
    public GameObject objeto2;

    private void Start()
    {
        // Suscribe una función al evento del ManagerRondas
        ManagerRondas.instance.On10RondasReached += ActivarObjetosExtras;
    }

    private void ActivarObjetosExtras()
    {
        // Activa los GameObjects adicionales
        objeto1.SetActive(true);
        objeto2.SetActive(true);
    }

    // Asegúrate de desuscribir la función cuando el objeto se destruye o deja de ser relevante
    private void OnDestroy()
    {
        ManagerRondas.instance.On10RondasReached -= ActivarObjetosExtras;
    }
}