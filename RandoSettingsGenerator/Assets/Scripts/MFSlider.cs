using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MFSlider : MonoBehaviour
{
    [SerializeField] private Slider mfSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Unknown: Off", "Unknown: On" };

    void Start()
    {
        mfSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        mfSlider.minValue = 0;
        mfSlider.maxValue = valueList.Count - 1;
        mfSlider.wholeNumbers = true;
        mfSlider.value = 0;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)mfSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getUnknownSliderValue()
    {
        return (int)mfSlider.value;
    }
}
