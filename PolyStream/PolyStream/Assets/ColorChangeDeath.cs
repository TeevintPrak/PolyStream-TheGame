using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeDeath : MonoBehaviour
{
    // Update is called once per frame
    bool darkMode;

    void Update()
    {
        bool darkMode = ColorChange.darkMode;
        Debug.Log(darkMode);
        if (darkMode == true)
        {
            FindObjectOfType<ColorChange>().SetDarkmode();
        }
        else if (darkMode == false)
        {
            FindObjectOfType<ColorChange>().SetOriginalColor();
        }
    }

    
}
