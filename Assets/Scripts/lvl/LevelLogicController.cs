using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLogicController : MonoBehaviour {

    public GameObject spot_1_button;
    public GameObject spot_1;
    public GameObject spot_1_green;
    public GameObject spot_1_button_green;

    public GameObject spot_2_button;
    public GameObject spot_2;
    public GameObject spot_2_green;
    public GameObject spot_2_button_green;

    public GameObject spot_3_button;
    public GameObject spot_3;
    public GameObject spot_3_green;
    public GameObject spot_3_button_green;

    public GameObject spot_4_button;
    public GameObject spot_4;
    public GameObject spot_4_green;
    public GameObject spot_4_button_green;

    public GameObject spot_5_button;
    public GameObject spot_5;
    public GameObject spot_5_red;
    
    public GameObject spot_6_button;
    public GameObject spot_6;
    public GameObject spot_6_red;

    public GameObject lost_window;
    public GameObject win_window;
    public GameObject pause_window;

    public Text Timer;
    public Slider Slider;

    public bool isEasy;

    private bool pressed_spot_1;
    private bool pressed_spot_2;
    private bool pressed_spot_3;
    private bool pressed_spot_4;
    private bool pressed_spot_5;
    private bool pressed_spot_6;

    private bool paused = false;

    private  int score = 0;
    private  int lose_score = 0;
    
    public float targetTime = 20.0f ;  
    // Start is called before the first frame update
    void Start()
    {
        initLevel();
        Timer.text = targetTime.ToString();
        
        lost_window.SetActive(false);
        win_window.SetActive(false);
        pressed_spot_1 = false;
        pressed_spot_2 = false;
        pressed_spot_3 = false;
        pressed_spot_4 = false;
        pressed_spot_5 = false;
        pressed_spot_6 = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(lose_score == 2) 
        {
            lostFunc();
        }
        else if(score >= 4) 
        {
            winFunc();
        } 
        else if( targetTime > 0.0f)
        {            
            if(!paused)
            {
                targetTime -= Time.deltaTime;  
                Slider.value = targetTime;
                Timer.text = Mathf.Round(targetTime).ToString();
            }
        }
        else
        { 
            lostFunc();   
        }
    }

    private void lostFunc()
    {
        //current_level = active_level;
        lost_window.SetActive(true);
    }

    private void winFunc() 
    {
        /*
        current_level++;
        if(current_level == 5) 
        {
            max_level++;
        }
        */
        win_window.SetActive(true);
    }

    private void initLevel() {
        //init spots in cow
        int object_index_1 = Random.Range(1, 5);
        
        int object_index_2 = Random.Range(1, 5);
        while(object_index_1 == object_index_2) 
        {
            object_index_2 = Random.Range(1, 5);
        }
        
        int object_index_3 = Random.Range(1, 5);
        while((object_index_3 == object_index_2) || (object_index_3 == object_index_1)) 
        {
            object_index_3 = Random.Range(1, 5);
        }

        int object_index_4 = Random.Range(1, 5);
        while((object_index_4 == object_index_3) || (object_index_4 == object_index_2) || (object_index_4 == object_index_1)) 
        {
            object_index_4 = Random.Range(1, 5);
        }


        spot_1.transform.position = getCowSpotCoordinates(object_index_1);        
        spot_2.transform.position = getCowSpotCoordinates(object_index_2);        
        spot_3.transform.position = getCowSpotCoordinates(object_index_3);
        spot_4.transform.position = getCowSpotCoordinates(object_index_4);

        spot_1_green.transform.position = spot_1.transform.position;
        spot_2_green.transform.position = spot_2.transform.position;
        spot_3_green.transform.position = spot_3.transform.position;
        spot_4_green.transform.position = spot_4.transform.position;
        //init spots in cow end

        //init spots buttons
        int button_index_1 = Random.Range(1, 7);
        
        int button_index_2 = Random.Range(1, 7);
        while(button_index_1 == button_index_2) 
        {
            button_index_2 = Random.Range(1, 7);
        }
        
        int button_index_3 = Random.Range(1, 7);
        while((button_index_3 == button_index_2) || (button_index_3 == button_index_1)) 
        {
            button_index_3 = Random.Range(1, 7);
        }

        int button_index_4 = Random.Range(1, 7);
        while((button_index_4 == button_index_3) || (button_index_4 == button_index_2) || (button_index_4 == button_index_1)) 
        {
            button_index_4 = Random.Range(1, 7);
        }

        int button_index_5 = Random.Range(1, 7);
        while((button_index_5 == button_index_4) || (button_index_5 == button_index_3) 
           || (button_index_5 == button_index_2) || (button_index_5 == button_index_1)) 
        {
            button_index_5 = Random.Range(1, 7);
        }

        int button_index_6 = Random.Range(1, 7);
        while((button_index_6 == button_index_5) || (button_index_6 == button_index_4) 
           || (button_index_6 == button_index_3) || (button_index_6 == button_index_2) 
           || (button_index_6 == button_index_1)) 
        {
            button_index_6 = Random.Range(1, 7);
        }

        // add rotation
        if(!isEasy)
        {
            if(button_index_1 % 2 == 0) {
                spot_1_button.transform.rotation = Quaternion.Euler(180, 180, 0);
                spot_1_button_green.transform.rotation = Quaternion.Euler(180, 180, 0);
            }
            if(button_index_2 % 2 == 0) {
                spot_2_button.transform.rotation = Quaternion.Euler(180, 180, 0);
                spot_2_button_green.transform.rotation = Quaternion.Euler(180, 180, 0);
            }
             if(button_index_3 % 2 == 0) {
                spot_3_button.transform.rotation = Quaternion.Euler(180, 180, 0);
                spot_3_button_green.transform.rotation = Quaternion.Euler(180, 180, 0);
            }
            spot_4_button.transform.rotation = Quaternion.Euler(180, 180, 0);
            spot_4_button_green.transform.rotation = Quaternion.Euler(180, 180, 0);
        }
        
        //add rotation end

        spot_1_button.transform.position = getButtonCoordinates(button_index_1);
        spot_2_button.transform.position = getButtonCoordinates(button_index_2);
        spot_3_button.transform.position = getButtonCoordinates(button_index_3);
        spot_4_button.transform.position = getButtonCoordinates(button_index_4);
        spot_5_button.transform.position = getButtonCoordinates(button_index_5);
        spot_6_button.transform.position = getButtonCoordinates(button_index_6);

        spot_1_button_green.transform.position = spot_1_button.transform.position; 
        spot_2_button_green.transform.position = spot_2_button.transform.position;
        spot_3_button_green.transform.position = spot_3_button.transform.position;
        spot_4_button_green.transform.position = spot_4_button.transform.position;
        spot_5_red.transform.position = spot_5_button.transform.position;
        spot_6_red.transform.position = spot_6_button.transform.position;
        //init spots buttons end

        
       
    }

    public Vector3 getCowSpotCoordinates(int i) {
        if(i == 1) 
        {
            return new Vector3(Globals.EASY_COW_SPOT_X_POSITION_1, Globals.EASY_COW_SPOT_Y_POSITION_1, 0);
        } 
        else if(i == 2) 
        {
            return new Vector3(Globals.EASY_COW_SPOT_X_POSITION_2, Globals.EASY_COW_SPOT_Y_POSITION_2, 0);
        } 
        else if(i == 3)
        {
            return new Vector3(Globals.EASY_COW_SPOT_X_POSITION_3, Globals.EASY_COW_SPOT_Y_POSITION_3, 0);
        }
        else
        {
            return new Vector3(Globals.EASY_COW_SPOT_X_POSITION_4, Globals.EASY_COW_SPOT_Y_POSITION_4, 0);
        }
    }

     public Vector3 getButtonCoordinates(int i) {
        if(i == 1) 
        {
            return new Vector3(Globals.EASY_SPOT_X_POSITION_1, Globals.EASY_SPOT_Y_POSITION_1, 0);
        } 
        else if(i == 2) 
        {
            return new Vector3(Globals.EASY_SPOT_X_POSITION_2, Globals.EASY_SPOT_Y_POSITION_2, 0);
        } 
        else if(i == 3)
        {
            return new Vector3(Globals.EASY_SPOT_X_POSITION_3, Globals.EASY_SPOT_Y_POSITION_3, 0);
        }
        else if(i == 4)
        {
            return new Vector3(Globals.EASY_SPOT_X_POSITION_4, Globals.EASY_SPOT_Y_POSITION_4, 0);
        }
        else if(i == 5)
        {
            return new Vector3(Globals.EASY_SPOT_X_POSITION_5, Globals.EASY_SPOT_Y_POSITION_5, 0);
        }
        else 
        {
            return new Vector3(Globals.EASY_SPOT_X_POSITION_6, Globals.EASY_SPOT_Y_POSITION_6, 0);
        }
    }

    public void press_pause() {
        pause_window.SetActive(true);
        paused = true;
    }

    public void press_continue() {
        pause_window.SetActive(false);
        paused = false;
    }

    public void press_1_spot() {
        if(!pressed_spot_1) {
        spot_1.SetActive (false);
        spot_1_green.SetActive (true);
        spot_1_button.SetActive (false);
        spot_1_button_green.SetActive (true);
        score++;
        pressed_spot_1 = true;
        }
    }

    public void press_2_spot() {
        if(!pressed_spot_2) {
        spot_2.SetActive (false);
        spot_2_green.SetActive (true);
        spot_2_button.SetActive (false);
        spot_2_button_green.SetActive (true);
        score++;
        pressed_spot_2 = true;
        }
    }

    public void press_3_spot() {
        if(!pressed_spot_3) {
        spot_3.SetActive (false);
        spot_3_green.SetActive (true);
        spot_3_button.SetActive (false);
        spot_3_button_green.SetActive (true);
        score++;
        pressed_spot_3 = true;
        }
    }

    public void press_4_spot() {
        if(!pressed_spot_4) {
        spot_4.SetActive (false);
        spot_4_green.SetActive (true);
        spot_4_button.SetActive (false);
        spot_4_button_green.SetActive (true);
        score++;
        pressed_spot_4 = true;
        }
    }

    public void press_5_spot() {
         if(!pressed_spot_5) {
        spot_5.SetActive (false);
        spot_5_red.SetActive (true);
        lose_score++;
        pressed_spot_5 = true;
        }
    }

    public void press_6_spot() {
         if(!pressed_spot_6) {
        spot_6.SetActive (false);
        spot_6_red.SetActive (true);
        lose_score++;
        pressed_spot_6 = true;
        }
    }
    /*public void press_4_spot() {
         if(!pressed_spot_4) {
        spot_4.SetActive (false);
        spot_4_red.SetActive (true);
        score = -1;
        pressed_spot_4 = true;
        }
    }*/
}
