using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerScenceAndMenu : MonoBehaviour
{
    public GameObject LvLButtons;
    public GameObject hardLevelButton;
    public GameObject StartButton;

    public static bool first_menu =  true;
    public int max_level = 1;
    // Start is called before the first frame update
    void Start()
    {
        if(first_menu) {
            StartButton.SetActive (true);
            LvLButtons.SetActive (false);
            hardLevelButton.SetActive(false);
            first_menu = false;
        } else {
            StartButton.SetActive (false);
            LvLButtons.SetActive (true);
             hardLevelButton.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
       if(max_level == 2) {
            hardLevelButton.SetActive (true);
       }
    }

    public void ShowLevelButtons() {
        StartButton.SetActive (false);
        LvLButtons.SetActive (true);
    }


    public void LoadLevel(int i) {
        SceneManager.LoadScene("lvl" + i);
        //Application.LoadLevel("lvl" + i);
    }
}
