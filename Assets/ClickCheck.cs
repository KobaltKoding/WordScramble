using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCheck : MonoBehaviour
{
    public GMScript gameManager;
    public Transform wordBoxes;
    public Transform result;
    public static int count = 0;


    public void Start()
    {
        
        GMScript.currentWord = "";
    }
    private void OnMouseDown()
    {
        DisableOption();

        
        if (count==wordBoxes.childCount)
        {            
              
            StartCoroutine(gameManager.Check());
            count = 0;
        }
    }

    /*public void EnableOption(string tmp)
    {
        
            if (GetComponent<TextMesh>().text == tmp)
            {
                GetComponent<Collider2D>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;//turns off collider so letter can be used just once
            }

        

    }*/

    public void DisableOption()//disable option once clicked
    {
        GMScript.currentWord += GetComponent<TextMesh>().text; //adds selected letter to the current word

        //Debug.Log(GMScript.currentWord);
        
        GetComponent<Collider2D>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;//turns off collider so letter can be used just once
        if (GMScript.currentWord != null)
        {
            wordBoxes.GetChild(count).GetChild(0).GetComponent<TextMesh>().text = (GMScript.currentWord[count]).ToString(); //put letter in the above box
            wordBoxes.GetChild(count).GetChild(0).GetComponent<Collider2D>().enabled = true;

            count++;

        }
    }
}
