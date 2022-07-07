using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponStatSlider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider weaponStatSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Vanilla Weapon Stats", "Weak Weapons Buffed", "Stats Shuffled", "Stats Shuffled/Weak Weapons Buffed" };

    void Start()
    {
        weaponStatSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        weaponStatSlider.minValue = 0;
        weaponStatSlider.maxValue = valueList.Count - 1;
        weaponStatSlider.wholeNumbers = true;
        weaponStatSlider.value = 3;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)weaponStatSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getWeaponStatSliderValue()
    {
        return (int)weaponStatSlider.value;
    }
}
