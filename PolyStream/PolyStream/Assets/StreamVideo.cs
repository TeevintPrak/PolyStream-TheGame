using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour
{
    public RawImage video;
    public VideoPlayer player;

    public void Play()
    {
        StartCoroutine(PlayVideo());
    }

    IEnumerator PlayVideo()
    {
        player.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(0.25f);
        while (!player.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        video.texture = player.texture;
        player.Play();
    }

    public void Stop()
    {
        player.Stop();
    }
}
