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

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider target)
    {
        // สำหรับการชนแบบ Is Trigger
        if (target.gameObject.tag.Equals("Item"))
        {
            // อยากให้ทำอะไร
            Destroy(target.gameObject);
            // เพิ่มค่าตัวแปร Score ขึ้นที่ละ 10 / Item
            score += 10;
            scoreText.text = "Item x " + score.ToString();
            audioSource.PlayOneShot(itemSound);
        }
    }
}
