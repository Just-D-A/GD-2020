using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelOptionsController : MonoBehaviour
{
    public static int active_level;

    public void goBackToMenu() 
    {
        SceneManager.LoadScene("Menu");
    }

    public void tryAgain() 
    {    
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void nextLevel(int i) 
    {    
        active_level = i;
        SceneManager.LoadScene("lvl" + i);
    }
}
