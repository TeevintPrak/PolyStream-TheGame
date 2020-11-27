using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BestTimer : MonoBehaviour
{
    public Text text;

    public void Start()
    {
        text = GetComponent<Text>();
    }
    public void SetBestTime(float timeValue, int scene)
    {
            if (scene == 1)
            {
                PlayerPrefs.SetFloat("time1", timeValue);
            }
            else if (scene == 2)
            {
                PlayerPrefs.SetFloat("time2", timeValue);
            }
            else if (scene == 3)
            {
                PlayerPrefs.SetFloat("time3", timeValue);
            }
            string minutes = Mathf.Floor((timeValue % 3600) / 60).ToString("00");
            string seconds = (timeValue % 60).ToString("f2");
            text.text = minutes + ":" + seconds;
    }
}
