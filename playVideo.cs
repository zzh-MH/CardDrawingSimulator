using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class playVideo : MonoBehaviour
{
    //private bool isplay = true;
    public RawImage thisImage;
    private Color c;
    private bool finished = false;
    private bool isplayed = false;
    private string rank;
    private int rare;
    public VideoClip[] rareVideo;
    public VideoPlayer videoPlayer;
    


    public void checkRare() {
        
            if (calculation_ten.tags.Contains("SSR"))
            {
                rare = 2;

            }

            else if (calculation_ten.tags.Contains("SR"))
            {
                rare = 1;

            }
            else
            {
                rare = 0;
            }
        
            
                
            
        
        
    }

    public void playSpecificVideo() {


        isplayed = false;
        
        
        StartCoroutine(isFinishPlaying());

    }

    // Start is called before the first frame update
    void Start()
    {
        // checkRare();
        thisImage.GetComponent<Image>();

        c = thisImage.color;
        finished = false;
        StartCoroutine(isFinishPlaying());
        playSpecificVideo();
    }

    // Update is called once per frame
    void Update()
    {
        checkRare();
       
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.SetActive(false);
        }
        if (rare == 2)
        {
            videoPlayer.clip = rareVideo[0];
           


        }
        else if (rare == 1)
        {
            videoPlayer.clip = rareVideo[1];
           
        }
        else
        {
            videoPlayer.clip = rareVideo[2];
            
        }

        if (!isplayed) {
            videoPlayer.Play();
            isplayed = true;
        }

        if (finished) {
            c.a -= 0.01f;
            thisImage.color = c;
        }

        //print(rank);
    }

    IEnumerator isFinishPlaying() {
        yield return new WaitForSeconds(9);
        finished = true;
    }
}
