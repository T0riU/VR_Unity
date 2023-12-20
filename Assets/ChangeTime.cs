using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ChangeTime : MonoBehaviour
{
    public UnityEngine.UI.Slider sl;
    public Light light;
    void Start()
    {
        sl.minValue = 0f;
        sl.maxValue = 24f;
        sl.onValueChanged.AddListener(OnSliderValueChanged);
    }
    public void OnSliderValueChanged(float value)
    {
        float rotationAngle = value * (360f / 24f);
        light.transform.rotation = Quaternion.Euler(rotationAngle, 0f, 0f);
    }
}
