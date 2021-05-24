using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform next;
    public Text scoreText;
    public static int score;
    // Start is called before the first frame update

     void Start()
    {
        //DontDestroyOnLoad(gameObject);
        scoreText.text = score.ToString();
    }
    public void ScorePlus()
    {
        score++;
        scoreText.text = score.ToString();//update score
        if (score < 10)
            FindObjectOfType<WordSelect>().Remove();
        else
        {
            next.GetComponent<MeshRenderer>().enabled = false;
            next.GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(ExitGame());
        }
           
    }

    public IEnumerator ExitGame()//wait 2 sec and then show end screen
    {
        yield return new WaitForSeconds(2);
        FindObjectOfType<ExitButton>().Exit();
    }

}
