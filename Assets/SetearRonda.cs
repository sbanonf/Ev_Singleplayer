using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetearRonda : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = "Ronda: " + ManagerRondas.instance.rondas;
    }
}
