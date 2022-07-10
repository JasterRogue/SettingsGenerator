using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalRestSlider : MonoBehaviour
{
    [SerializeField] private Slider finalRestSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Final Rest: Off", "Final Rest: On" };

    // Start is called before the first frame update
    void Start()
    {
        finalRestSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        finalRestSlider.minValue = 0;
        finalRestSlider.maxValue = valueList.Count - 1;
        finalRestSlider.wholeNumbers = true;
        finalRestSlider.value = 1;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)finalRestSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getFinalRestSliderValue()
    {
        return (int)finalRestSlider.value;
    }
}
