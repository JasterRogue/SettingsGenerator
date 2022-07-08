using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HBGoSlider : MonoBehaviour
{
    [SerializeField] private Slider hbGoSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "HB Go Mode: Off", "HB Go Mode: On" };

    // Start is called before the first frame update
    void Start()
    {
        hbGoSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        hbGoSlider.minValue = 0;
        hbGoSlider.maxValue = valueList.Count - 1;
        hbGoSlider.wholeNumbers = true;
        hbGoSlider.value = 0;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)hbGoSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getHBGoSliderValue()
    {
        return (int)hbGoSlider.value;
    }
}
