using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLogicController : MonoBehaviour
{
    public GameObject spot_1;
    public GameObject spot_1_green;
    public GameObject spot_2;
    public GameObject spot_2_green;
    public GameObject spot_3;
    public GameObject spot_3_green;
    public GameObject spot_4;
    public GameObject spot_4_red;

    public GameObject lost_window;
    public GameObject win_window;

    private int score = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        lost_window.SetActive(false);
        win_window.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      if(score == -1) {
          lost_window.SetActive(true);
      }
      if(score >= 3) {
          win_window.SetActive(true);
      }
    }

    public void press_1_spot() {
        spot_1.SetActive (false);
        spot_1_green.SetActive (true);
        score++;
    }
     
    public void press_2_spot() {
        spot_2.SetActive (false);
        spot_2_green.SetActive (true);
        score++;
    }

    public void press_3_spot() {
        spot_3.SetActive (false);
        spot_3_green.SetActive (true);
        score++;
    }

     public void press_4_spot() {
        spot_4.SetActive (false);
        spot_4_red.SetActive (true);
        score = -1;
    }
}
