using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseUI;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Ternary Condition
            //Time.timeScale = (Time.timeScale == 1) ? 0:1;
            //pauseUI.SetActive(!Convert.ToBoolean(Time.timeScale));

            // If Condition
            if (Time.timeScale == 1)
            {
                // หยุดเกม
                Time.timeScale = 0;
                pauseUI.SetActive(true);
            }
            else
            {
                // เล่นเกมต่อ
                Time.timeScale = 1;
                pauseUI.SetActive(false);
            }
        }
    }
}
