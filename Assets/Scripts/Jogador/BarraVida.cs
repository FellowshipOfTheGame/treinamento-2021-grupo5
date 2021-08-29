using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Slider slider;

    public void DefinirVidaMax(int vida)
    {
        slider.maxValue = vida;
        slider.value = vida;
    }
    public void DefinirVida(int vida)
    {
        slider.value = vida;
    }
}
