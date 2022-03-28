using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class Streaming : MonoBehaviour
{
    public RawImage video2;
    public VideoPlayer vp2;
   
    // Use this for initialization
    void FixedUpdate()
    {
        StartCoroutine(PlayVideo());
    }
    IEnumerator PlayVideo()
    {
        vp2.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (!vp2.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        video2.texture = vp2.texture;
        vp2.Play();
        
    }
}