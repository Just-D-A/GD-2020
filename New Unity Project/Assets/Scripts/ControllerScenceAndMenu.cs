using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScenceAndMenu : MonoBehaviour
{
    public GameObject LvLButtons;
    public GameObject StartButton;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ShowLevelButtons() {
        StartButton.SetActive (false);
        LvLButtons.SetActive (true);
    }


    public void LoadLevel(int i) {
        Application.LoadLevel("lvl" + i);
    }
}
