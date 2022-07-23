using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DJSlider : MonoBehaviour
{
    [SerializeField] private Slider djSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Slides Randomized: 0", "Slides Randomized: 1", "Slides Randomized: 2", "Slides Randomized: 3", "Slides Randomized: 4", "Slides Randomized: 5", "Slides Randomized: 6" };

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
