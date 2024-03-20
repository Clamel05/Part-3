using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIDemo : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Dropdown dropdown;
    public SpriteRenderer sr;
    public Color start;
    public Color end;
    float interpolation;

    public void SliderValueHasChanged(Single value)
    {
        interpolation = value;
    }

    private void Update()
    {
        sr.color = Color.Lerp(start, end, (interpolation/60));
    }

    public void DropdownHasChanged(int index)
    {
        Debug.Log(dropdown.options[index].text);
    }
    
}
