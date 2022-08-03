using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HTSlider : MonoBehaviour
{
    [SerializeField] private Slider htSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Halloween Town Locked", "Halloween Town Unlocked" };

    // Start is called before the first frame update
    void Start()
    {
        htSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        htSlider.minValue = 0;
        htSlider.maxValue = valueList.Count - 1;
        htSlider.wholeNumbers = true;
        htSlider.value = 1;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)htSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getHTSliderValue()
    {
        return (int)htSlider.value;
    }
}
