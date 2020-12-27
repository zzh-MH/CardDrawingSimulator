using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class playVideo_single : MonoBehaviour
{
    public VideoClip[] rareVideo;
    public VideoPlayer videoPlayer;
    public RawImage thisImage;
    private bool finished = false;
    private Color c;
    private bool isplayed = false;
    // Start is called before the first frame update
    void Start()
    {
        finished = false;
        StartCoroutine(isFinishPlaying());
        playSpecificVideo();
    }
   
    // Update is called once per frame

    public void playSpecificVideo()
    {


        isplayed = false;


        StartCoroutine(isFinishPlaying());

    }
    IEnumerator isFinishPlaying()
    {
        yield return new WaitForSeconds(9);
        finished = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            this.gameObject.SetActive(false);
        }

        if (calculation.rare == "SSR")
        {
            videoPlayer.clip = rareVideo[0];



        }
        else if (calculation.rare == "SR")
        {
            videoPlayer.clip = rareVideo[1];

        }
        else
        {
            videoPlayer.clip = rareVideo[2];

        }
        if (finished)
        {
            c.a -= 0.01f;
            thisImage.color = c;
        }
        if (!isplayed)
        {
            videoPlayer.Play();
            isplayed = true;
        }
    }
}
