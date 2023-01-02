using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progressbar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;

    public void SetMaxHealth(int progress){
        slider.maxValue = progress;
        slider.value = progress;
    }

    public void SetHealth(int progress){
        slider.value = progress;
    }

}
