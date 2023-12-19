using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PickItem : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText;
    private AudioSource audioSource;
    public AudioClip itemSound;
    public AudioClip completeSound;

    // ตัวแปรนับจำนวนไอเท็ม
    int itemCount;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreText.text = "Item x " + score.ToString() + "/" + itemCount.ToString();
    }

    private void OnTriggerEnter(Collider target)
    {
        // สำหรับการชนแบบ Is Trigger
        if (target.gameObject.tag.Equals("Item"))
        {
            // อยากให้ทำอะไร
            Destroy(target.gameObject);
            // เพิ่มค่าตัวแปร Score ขึ้นที่ละ 1 / Item
            score += 1;
            scoreText.text = "Item x " + score.ToString() + "/" + itemCount.ToString();
            if (score >= itemCount)
            {
                audioSource.PlayOneShot(completeSound);
            }
            else
            {
                audioSource.PlayOneShot(itemSound);
            }
        }
    }
}
