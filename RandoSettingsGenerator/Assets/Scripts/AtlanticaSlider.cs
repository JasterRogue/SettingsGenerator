using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtlanticaSlider : MonoBehaviour
{
    [SerializeField] private Slider atlanticaSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Atlantica: Off", "Atlantica: On" };

    // Start is called before the first frame update
    void Start()
    {
        atlanticaSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        atlanticaSlider.minValue = 0;
        atlanticaSlider.maxValue = valueList.Count - 1;
        atlanticaSlider.wholeNumbers = true;
        atlanticaSlider.value = 0;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)atlanticaSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getAtlanticaSliderValue()
    {
        return (int)atlanticaSlider.value;
    }
}
