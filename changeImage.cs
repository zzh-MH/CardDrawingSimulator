using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeImage : MonoBehaviour
{
   
    public Sprite SSR;
    public Sprite SR;
    public Sprite R;
    public Sprite N;
    // Start is called before the first frame update
    void Start()
    {
      
        
       
        



    }

    public void imageChanging() {
        
        if (calculation.rare == "SSR")
        {
            GetComponent<Image>().sprite = SSR;
        }
        else if (calculation.rare == "SR")
        {
            GetComponent<Image>().sprite = SR;
        }
        else if (calculation.rare == "R")
        {
            GetComponent<Image>().sprite = R;
        }
        else if(calculation.rare == "N")
        {
            GetComponent<Image>().sprite = N;
        }
    }

    // Update is called once per frame
    void Update()
    {
        imageChanging();
    }
}
