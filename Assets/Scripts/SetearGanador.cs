using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetearGanador : MonoBehaviour
{
    public TextMeshProUGUI premio;
    public TextMeshProUGUI apuesta;
    public TextMeshProUGUI apuestar;
    public TextMeshProUGUI nombrerival;
    public TextMeshProUGUI Estado;
    public TextMeshProUGUI Balance;

    public void SetearTextos(string _premio, string _apuesta, string _apuestar, string _nombrerival,string _Estado,string _Balance)
    {
        premio.text = _premio;
        apuesta.text = _apuesta;
        apuestar.text = _apuestar;
        nombrerival.text = _nombrerival;
        Estado.text = _Estado;
        Balance.text = _Balance;
    }
}
