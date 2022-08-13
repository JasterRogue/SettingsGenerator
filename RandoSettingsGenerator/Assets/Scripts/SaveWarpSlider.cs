using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveWarpSlider : MonoBehaviour
{
    [SerializeField]private Slider warpSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Gummi Warps: Locked", "Gummi Warps: Blue HUD Only", "Gummi Warp: Unrestricted"};

    // Start is called before the first frame update
    void Start()
    {
        warpSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        warpSlider.minValue = 0;
        warpSlider.maxValue = valueList.Count - 1;
        warpSlider.wholeNumbers = true;
        warpSlider.value = 2;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)warpSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getWarpSliderValue()
    {
        return (int)warpSlider.value;
    }
}
