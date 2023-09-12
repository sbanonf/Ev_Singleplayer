using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorEscenas : MonoBehaviour
{
    public void CambiarEscena(string nombreDeEscena)
    {
        if (SceneManager.GetActiveScene().name.Equals("VS"))
        {
            ManagerRondas.instance.AdicionarRonda();
            SceneManager.LoadScene(nombreDeEscena);
        }
        else if(!SceneManager.GetActiveScene().name.Equals("VS")){
            SceneManager.LoadScene(nombreDeEscena);
        }

        
    }

}
