﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WLSlider : MonoBehaviour
{
    [SerializeField] private Slider wlSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Wonderland Locked", "Wonderland Unlocked"};

    // Start is called before the first frame update
    void Start()
    {
        wlSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        wlSlider.minValue = 0;
        wlSlider.maxValue = valueList.Count - 1;
        wlSlider.wholeNumbers = true;
        wlSlider.value = 1;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)wlSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getWLSliderValue()
    {
        return (int)wlSlider.value;
    }
}