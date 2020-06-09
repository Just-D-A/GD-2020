using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LevelOptionsController : MonoBehaviour
{
    public static int active_level;

    public void goBackToMenu() 
    {
        Globals.LEVEL_COMPLITED = 0;
        SceneManager.LoadScene("Menu");
    }

    public void tryAgain(int i) 
    {    
        Globals.LEVEL_COMPLITED = 0;
        SceneManager.LoadScene("lvl" + i);
    }
    
    public void nextLevel(int i) 
    {    
        active_level = i;
        SceneManager.LoadScene("lvl" + i);
    }
}
