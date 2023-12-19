using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Time.timeScale = Convert.ToBoolean(Time.timeScale) ? 0:1;

            if (Time.timeScale == 1)
            {
                // หยุดเกม
                Time.timeScale = 0;
            }
            else
            {
                // เล่นเกมต่อ
                Time.timeScale = 1;
            }
        }
    }
}
