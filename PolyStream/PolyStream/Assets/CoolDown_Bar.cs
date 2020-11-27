using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class CoolDown_Bar : MonoBehaviour
{
    public GameObject bar;
    float resetTime = 0.45f;
    float coolDownTime = 5;

    public void CoolDownBar()
    {
        LeanTween.scaleX(bar, 3, coolDownTime);
    }
    public void ResetBar()
    {
        LeanTween.scaleX(bar, 0, resetTime);
    }

}
