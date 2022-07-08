using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OlympusSlider : MonoBehaviour
{
    [SerializeField] private Slider ocSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Olympus Coliseum Locked", "Olympus Coliseum Unlocked" };

    // Start is called before the first frame update
    void Start()
    {
        ocSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        ocSlider.minValue = 0;
        ocSlider.maxValue = valueList.Count - 1;
        ocSlider.wholeNumbers = true;
        ocSlider.value = 1;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)ocSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getOCSliderValue()
    {
        return (int)ocSlider.value;
    }
}
