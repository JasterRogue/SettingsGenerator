using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AWSlider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider awSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "100 Acre Wood: Off", "Up to Page 1 Randomized", "Up to Page 3 Randomized", "Up to page 4 randomized", "Up to page 6 randomized", "All Pages/Cheer Randomized" };

    // Start is called before the first frame update
    void Start()
    {
        awSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        awSlider.minValue = 0;
        awSlider.maxValue = valueList.Count - 1;
        awSlider.wholeNumbers = true;
        awSlider.value = 0;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)awSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getAWSliderValue()
    {
        return (int)awSlider.value;
    }
}
