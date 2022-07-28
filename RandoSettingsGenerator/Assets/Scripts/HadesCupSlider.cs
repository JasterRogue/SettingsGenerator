using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HadesCupSlider : MonoBehaviour
{
    [SerializeField] private Slider hadesCupSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Hades Cup: Off", "Group Randomized", "Solo Randomized", "All Stages Randomized" };

    // Start is called before the first frame update
    void Start()
    {
        hadesCupSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        hadesCupSlider.minValue = 0;
        hadesCupSlider.maxValue = valueList.Count - 1;
        hadesCupSlider.wholeNumbers = true;
        hadesCupSlider.value = 0;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)hadesCupSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getHadesSliderValue()
    {
        return (int)hadesCupSlider.value;
    }
}
