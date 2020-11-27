using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    Text text;
    float currentTime;
    public float speed = 1;
    bool count;
    // Start is called before the first frame update
    void Start()
    {
        count = true;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (count)
        {
            currentTime += Time.deltaTime * speed;
            string minutes = Mathf.Floor((currentTime % 3600) / 60).ToString("00");
            string seconds = (currentTime % 60).ToString("f2");
            text.text = minutes + ":" + seconds;
        }
    }

    void TimeReset()
    {
        currentTime = 0;
    }

    public void SetTime(float timeValue, int scene)
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

    public void StopTimer(int scene)
    {
        count = false;
        if (scene == 1)
        {
            PlayerPrefs.SetFloat("time1", currentTime);
        }
        else if (scene == 2)
        {
            PlayerPrefs.SetFloat("time2", currentTime);
        }
        else if (scene == 3)
        {
            PlayerPrefs.SetFloat("time3", currentTime);
        }
    }

    public float GetTime(int scene)
    {
        count = false;
        if (scene == 1)
        {
            currentTime = PlayerPrefs.GetFloat("time1");
            return currentTime;
        }
        else if (scene == 2)
        {
            currentTime = PlayerPrefs.GetFloat("time2");
            return currentTime;
        }
        else if (scene == 3)
        {
            currentTime = PlayerPrefs.GetFloat("time3");
            return currentTime;
        }

        else return 0;

    }


    public void ResetTimer(int scene)
    {
        Debug.Log("ResetTimer");   
        if (scene == 1)
        {
            currentTime = 0;
            PlayerPrefs.SetFloat("time1", currentTime);
        }
        else if (scene == 2)
        {
            currentTime = 0;
            PlayerPrefs.SetFloat("time2", currentTime);
        }
        else if (scene == 3)
        {
            currentTime = 0;
            PlayerPrefs.SetFloat("time3", currentTime);
        }
    }

}
