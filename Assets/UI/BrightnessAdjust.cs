using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessAdjust : MonoBehaviour
{
    public Slider BrightnessSlider;
    public Image UI_alpha;
    public Color Brightness;
    void Start()
    {
        SetBrightness(PlayerPrefs.GetFloat("SaveBrightness",0));
    }
    public void SetBrightness(float _value)
    {
        RefreshSlider(_value);
        Brightness.a = _value;
        UI_alpha.color = Brightness;
        PlayerPrefs.SetFloat("SaveBrightness",_value);
    }
    public void SetBrightnessFromSlider()
    {
        SetBrightness(BrightnessSlider.value);

    }
    public void RefreshSlider(float _value)
    {
        BrightnessSlider.value=_value;
    }
}
