using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class setearDataRonda : MonoBehaviour
{

    public TextMeshProUGUI rondafinal;
    public TextMeshProUGUI rondainic;

    private void Start()
    {
        rondainic.text = ManagerRondas.instance.rondas.ToString();
        rondafinal.text = ManagerRondas.instance.rondas_max.ToString();
    }
}

