using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeText : MonoBehaviour
{
    public Text result;
    // Start is called before the first frame update
    void Start()
    {
        result.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (calculation.rare == "SSR") {
            result.text = "SSR";
            result.color = Color.yellow;
        }
        else if (calculation.rare == "SR") {
            result.text = "SR";
            result.color = Color.magenta;
        }
        else if (calculation.rare == "R")
        {
            result.text = "R";
            result.color = Color.blue;
        }
        else if (calculation.rare == "N")
        {
            result.text = "N";
            result.color = Color.white;
        }
    }
}
