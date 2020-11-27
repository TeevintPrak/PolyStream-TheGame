using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour
{
    public GameObject Video;
    public StreamVideo stream;
    bool pressed = false;

    public void PlayTheVideo()
    {
        if (pressed == false)
        {
            Video.SetActive(true);
            stream.Play();
            pressed = true;
        }
        else
        {
            stream.Stop();
            Video.SetActive(false);
            pressed = false;
        }
    }
}
