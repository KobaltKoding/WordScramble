using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMScript : MonoBehaviour
{
    private OptionsShuffle options;
   
    
    public static string currentWord;
    public Transform spelling;
    public Transform wordBoxes;
    public Transform result;
    //public Transform options;
    public static string right;
    // Start is called before the first frame update
    void Start()
    {
        options = GameObject.Find("Options").GetComponent<OptionsShuffle>(); //getting the correct word form OptionsShuffle class 
        right = options.word;
        Debug.Log(right);
    }

    
    void Update()
    {
        spelling.GetComponent<TextMesh>().text = currentWord;
        if(ClickCheck.count == wordBoxes.childCount) 
        {
            
        }
       

    }


   public void Check()
    {
        if (currentWord == right)
            result.GetChild(0).GetComponent<TextMesh>().text = "Congrats";
        else
            result.GetChild(0).GetComponent<TextMesh>().text = "nono";
    }
}
