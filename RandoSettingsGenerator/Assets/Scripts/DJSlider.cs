using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DJSlider : MonoBehaviour
{
    [SerializeField] private Slider djSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Deep Jungle: Unlocked", "Slides Required: 1", "Slides Required: 2", "Slides Required: 3", "Slides Required: 4", "Slides Required: 5", "Slides Required: 6" };

    // Start is called before the first frame update
    void Start()
    {
        djSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        djSlider.minValue = 0;
        djSlider.maxValue = valueList.Count - 1;
        djSlider.wholeNumbers = true;
        djSlider.value = 0;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)djSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getDJSliderValue()
    {
        return (int)djSlider.value;
    }
}
