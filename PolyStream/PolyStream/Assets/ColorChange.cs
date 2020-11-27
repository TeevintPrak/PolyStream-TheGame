using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{ 
    Image panel;
    Color originalColor;
    Color originalColorT;
    public Text txt;
    static public bool darkMode;

    void Start()
    {
        panel = GetComponent<Image>();
        originalColor = panel.color;
        originalColorT = txt.color;
    }

    public void SetPanelColor(float r, float g, float b)
    {
        panel.color = Color(r, g, b);
    }

    public void SetOriginalColor()
    {
        panel.color = originalColor;
        txt.color = originalColorT;
        darkMode = false;
    }

    public void SetDarkmode()
    {
        panel.color = Color(0, 0, 0);
        txt.color = Color(200, 200, 200);
        darkMode = true;
    }

    Color Color(float r, float g, float b)
    {
        return new Color(r, g, b);
    }

}

