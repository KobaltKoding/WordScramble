using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{

    public void OnMouseDown()
    {
        
        FindObjectOfType<GMScript>().NextLevel();
        
    }

    
}
