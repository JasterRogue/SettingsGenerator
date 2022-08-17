using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopRandoSlider : MonoBehaviour
{
    [SerializeField] private Slider shopSlider;
    [SerializeField] private Text currentValue = null;
    private List<string> valueList = new List<string> { "Shop/Synth: Vanilla", "Shop/Synth: No Key Items", "Shop/Synth: Fully Randomized" };

    // Start is called before the first frame update
    void Start()
    {
        shopSlider.onValueChanged.AddListener(delegate { SliderValueChangedCallback(); });

        // assuring that our slider is setup properly to map values
        shopSlider.minValue = 0;
        shopSlider.maxValue = valueList.Count - 1;
        shopSlider.wholeNumbers = true;
        shopSlider.value = 2;
    }

    private void SliderValueChangedCallback()
    {
        // grab out numeric value of the slider - cast to int as the value should be a whole number
        int numericSliderValue = (int)shopSlider.value;

        // debugging - do whatever you want with this value
        currentValue.text = valueList[numericSliderValue];
    }

    public int getShopSliderValue()
    {
        return (int)shopSlider.value;
    }
}
