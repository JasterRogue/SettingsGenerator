using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementSlider : MonoBehaviour
{
    [SerializeField] private Slider movementSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Vanilla Movement. No stacking", "High Jump Stacks", "All Movement Stacks" };

    // Start is called before the first frame update
    void Start()
    {
        movementSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        movementSlider.minValue = 0;
        movementSlider.maxValue = valueList.Count - 1;
        movementSlider.wholeNumbers = true;
        movementSlider.value = 2;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)movementSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getMovementSliderValue()
    {
        return (int)movementSlider.value;
    }
}
