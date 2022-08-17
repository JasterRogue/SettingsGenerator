using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceTitanSlider : MonoBehaviour
{
    [SerializeField] private Slider iceTitanSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Ice Titan: Off", "Ice Titan: On" };

    void Start()
    {
        iceTitanSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        iceTitanSlider.minValue = 0;
        iceTitanSlider.maxValue = valueList.Count - 1;
        iceTitanSlider.wholeNumbers = true;
        iceTitanSlider.value = 1;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)iceTitanSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getIceTitanSliderValue()
    {
        return (int)iceTitanSlider.value;
    }
}
