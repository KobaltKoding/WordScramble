using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; //added for using ByOrder in Scrambled funtions

public class OptionsShuffle : MonoBehaviour
{
    
    public string word= "BIRD" ; //enter the correct word here
    
    public Transform options;
    // Start is called before the first frame update
    void Start()
    {   
        string shuffled = Scrambled(word);
        while(shuffled==word)  //scramble again if scrambled is same as original
            shuffled = Scrambled(word);
        for (int i=0;i<word.Length ;i++)
        options.GetChild(i).GetComponent<TextMesh>().text = shuffled[i].ToString(); //display scrambled options
    }

    

    public string Scrambled(string input)
    {
        string str = input;

        // The random number sequence
        System.Random num = new System.Random();

        // Create new string from the reordered char array
        string rand = new string(str.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
        return rand;
    }
}