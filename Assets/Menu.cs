
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
   public void StartGame()
    {
        int index = Random.Range(1, 4);
        SceneManager.LoadScene(index);
    }
}
