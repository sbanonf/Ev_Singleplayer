using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarObjeto : MonoBehaviour
{
    public GameObject objetoADesactivar; // Referencia al GameObject que deseas desactivar

    public void Desactivar_Objeto()
    {
        // Verifica si el objeto existe y, si es así, desactívalo
        if (objetoADesactivar != null)
        {
            ManagerRondas.instance.ejecutado = true;
            objetoADesactivar.SetActive(false);
        }
    }
}
