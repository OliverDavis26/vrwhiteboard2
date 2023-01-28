using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public Material material;
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;

    void Start()
    {
        redSlider.onValueChanged.AddListener(ChangeColor);
        greenSlider.onValueChanged.AddListener(ChangeColor);
        blueSlider.onValueChanged.AddListener(ChangeColor);
    }

    void ChangeColor(float value)
    {
        material.color = new Color(redSlider.value, greenSlider.value, blueSlider.value);
    }
}
