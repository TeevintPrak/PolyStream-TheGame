using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeToDarkMode : MonoBehaviour
{
    Image button;
    Color currentColor;
    Color darkColor;
    Color lightColor;
    float darkColorRGB = 0f;
    float lightColorR = 255f;
    float lightColorG = 255f;
    float lightColorB = 255f;
    bool pressed = false;

    void Start()
    {
        button = GetComponent<Image>();
        currentColor = button.color;
        darkColor = new Color(darkColorRGB, darkColorRGB, darkColorRGB);
        lightColor = new Color(lightColorR, lightColorG, lightColorB);
    }
    public void ChangeColorToDarkMode()
    {
        if (pressed == false)
        {
            FindObjectOfType<ColorChange>().SetDarkmode();
            pressed = true;
        }
        else
        {
            FindObjectOfType<ColorChange>().SetOriginalColor();
            pressed = false;
        }

        if (currentColor == darkColor)
        {
            button.color = lightColor;
        }
        else if(currentColor == lightColor)
        {
            button.color = darkColor;
        }
    }
}
