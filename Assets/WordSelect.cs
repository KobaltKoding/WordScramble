using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WordSelect : MonoBehaviour
{
    public static string[] wordList={"BIRD","LION","BALL", "BOOK","DUCK","ROPE","STAR","KITE", 
                                    "BENCH","APPLE","HONEY","CANDY","CYCLE","BRUSH","ARROW","HEART",
                                     "DOG","CAR","COW","BAT","CAT","HAT","SUN","PEN"};

    public static string newWord;
    int index;

    public void Generate()//generate random array of words
    {
        /*for(int i=0;i<wordList.Length;i++)
        {
            string tmp = wordList[i];
            int r = Random.Range(i, wordList.Length);
            wordList[i] = wordList[r];
            wordList[r] = tmp;
            
        }*/
        int index = Random.Range(0, wordList.Length-1);
        newWord = wordList[index];
        //Debug.Log(wordList[0]);
    }

    public void Remove()
    {

        wordList = wordList.Where(e => e != newWord).ToArray();
        //wordList = wordList.Skip(index).ToArray();
        
    }
}
