using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SephirothSlider : MonoBehaviour
{
    [SerializeField] private Slider sephirothSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Sephiroth: Off", "Sephiroth: On" };

    void Start()
    {
        sephirothSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        sephirothSlider.minValue = 0;
        sephirothSlider.maxValue = valueList.Count - 1;
        sephirothSlider.wholeNumbers = true;
        sephirothSlider.value = 0;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)sephirothSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getSephirothSliderValue()
    {
        return (int)sephirothSlider.value;
    }
}
