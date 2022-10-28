using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EOTWSkipSlider : MonoBehaviour
{
    [SerializeField] private Slider eotwSkipSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "EOTW Skip: Disabled", "EOTW Skip: Enabled" };

    // Start is called before the first frame update
    void Start()
    {
        eotwSkipSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        eotwSkipSlider.minValue = 0;
        eotwSkipSlider.maxValue = valueList.Count - 1;
        eotwSkipSlider.wholeNumbers = true;
        eotwSkipSlider.value = 1;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)eotwSkipSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getEOTWSkipSliderValue()
    {
        return (int)eotwSkipSlider.value;
    }
}
