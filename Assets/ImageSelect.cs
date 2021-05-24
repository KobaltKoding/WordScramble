using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSelect : MonoBehaviour
{
    public OptionsShuffle options;
    public void Enable(string correct)
    {
        
        GameObject.Find(correct).GetComponent<SpriteRenderer>().enabled = true;
    }

    public void Disable(string correct)
    {
        GameObject.Find(correct).GetComponent<SpriteRenderer>().enabled = false;
    }

    public void display()//display the image selected
    { 

        options = GameObject.Find("Options").GetComponent<OptionsShuffle>(); //getting the correct word form OptionsShuffle class 
        string right = options.word;
        
        Enable(right);
        Debug.Log(right);

        }
}
