using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DIGoSlider : MonoBehaviour
{
    [SerializeField] private Slider diGoSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "DI Go Mode: Off", "DI Go Mode: On" };

    // Start is called before the first frame update
    void Start()
    {
        diGoSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        diGoSlider.minValue = 0;
        diGoSlider.maxValue = valueList.Count - 1;
        diGoSlider.wholeNumbers = true;
        diGoSlider.value = 0;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)diGoSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getDIGoSliderValue()
    {
        return (int)diGoSlider.value;
    }
}
