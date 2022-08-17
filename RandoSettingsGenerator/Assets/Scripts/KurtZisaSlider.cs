using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KurtZisaSlider : MonoBehaviour
{
    [SerializeField] private Slider kurtZisaSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Kurt Zisa: Off", "Kurt Zisa: On" };

    void Start()
    {
        kurtZisaSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        kurtZisaSlider.minValue = 0;
        kurtZisaSlider.maxValue = valueList.Count - 1;
        kurtZisaSlider.wholeNumbers = true;
        kurtZisaSlider.value = 1;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)kurtZisaSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getKurtZisaSliderValue()
    {
        return (int)kurtZisaSlider.value;
    }
}
