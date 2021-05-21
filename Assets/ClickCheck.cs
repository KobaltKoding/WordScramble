using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCheck : MonoBehaviour
{
    public GMScript gameManager;
    public Transform wordBoxes;
    public Transform result;
    public static int count = 0;
    
   

    private void OnMouseDown()
    {
        GMScript.currentWord += GetComponent<TextMesh>().text; //adds selected letter to the current word
        
        Debug.Log(GMScript.currentWord);
        GetComponent<Collider2D>().enabled = false; //turns off collider so letter can be used just once
        if (GMScript.currentWord != null )
        {
            wordBoxes.GetChild(count).GetChild(0).GetComponent<TextMesh>().text = (GMScript.currentWord[count]).ToString(); //put letter in the above box
            count++;
            
        }
        
        if (count==wordBoxes.childCount)
        {

            
                Debug.Log("11111");
                gameManager.Check();
            
        }
    }
    
    
    
}
