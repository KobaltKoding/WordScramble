using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMScript : MonoBehaviour
{
    private OptionsShuffle options;
    private ImageSelect imageSelect;


    public Transform next;



    public static string currentWord;
    public Transform spelling;
    public Transform wordBoxes;
    public Transform result;
   
    public Transform image;
   // public Transform options;
    public static string right="";
    // Start is called before the first frame update
    void Start()
    {
        options = GameObject.Find("Options").GetComponent<OptionsShuffle>(); //getting the correct word form OptionsShuffle class 
        right = options.word;

       
        Debug.Log(right);
    }

    
    void Update()
    {       

    }


   public IEnumerator Check()//check if ans is correct
    {
        next.GetComponent<MeshRenderer>().enabled = true;
        next.GetComponent<BoxCollider2D>().enabled = true;

        right = options.word;
        imageSelect = GameObject.Find("Image").GetComponent<ImageSelect>();
        imageSelect.Disable(right);
        
        Debug.Log(right);
        Debug.Log(currentWord);
        Debug.Log("above ig");
        if (currentWord == right)
        {
            Debug.Log("enter if");
            result.GetChild(0).GetComponent<TextMesh>().text = "Congrats";
            FindObjectOfType<Score>().ScorePlus();
            FindObjectOfType<WordSelect>().Remove();
    
        }
        else
        {
            result.GetChild(0).GetComponent<TextMesh>().text = right;
            yield return new WaitForSeconds(2);
            result.GetChild(0).GetComponent<TextMesh>().text = "Try Again";
        }

        currentWord = "";
    }


    public void NextLevel()//load next level randomly
    {   
        int index = Random.Range(1, 4);
        SceneManager.LoadScene(index);
    }
    
}
