using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculation : MonoBehaviour
{
    private int result;
    public static string rare;
    public Text resultText;
    public Image image;
    public Sprite SSR;
    public Sprite SR;
    public Sprite R;
    public Sprite N;
    // Start is called before the first frame update
    void Start()
    {
        calculateResualt();
        changeImage();
        changeText();
    }

    private void calculateResualt()
    {
       
        result = Random.Range(1, 101);
        if (result == 100) {
            rare = "SSR";
            
        }
        else if (result >= 1 && result <= 50) {
            rare = "N";
            
        }
        else if (result > 50 && result <= 79) {
            rare = "R";

        }
        else {
            rare = "SR";
        }
        
    }
    private void changeText()
    {

        if (rare == "SSR")
        {
            resultText.text = "SSR";
            resultText.color = Color.yellow;
        }
        else if (rare == "SR")
        {
            resultText.text = "SR";
            resultText.color = Color.magenta;
        }
        else if (rare == "R")
        {
            resultText.text = "R";
            resultText.color = Color.blue;
        }
        else if (rare == "N")
        {
            resultText.text = "N";
            resultText.color = Color.white;
        }
    }

    private void changeImage()
    {
        if (rare == "SSR")
        {
            image.sprite = SSR;
        }
        else if (rare == "SR")
        {
            image.sprite = SR;
        }
        else if (rare == "R")
        {
            image.sprite = R;
        }
        else if (rare == "N")
        {
            image.sprite = N;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
