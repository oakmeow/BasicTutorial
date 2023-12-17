using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public float speed = 10.0f; // ค่าความเร็วในการเคลื่อนที่ของวัตถุ
    private Rigidbody rb;
    public Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Jump");
        float z = Input.GetAxis("Vertical");
        movement = new Vector3(x, y, z);

        /*
        // ทำงานกับ Mouse ซ้าย
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0f, 1f * speed, 0f);
        }
        // ทำงานกับ Mouse ขวา
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0f, -1f * speed, 0f);
        }
        // ทำงานกับ Mouse กลาง
        if (Input.GetMouseButtonDown(2))
        {
            transform.Rotate(-1f * speed, 0f, 0f);
        }*/
    }

    private void FixedUpdate()
    {
        //movePlayer(movement);
    }

    void movePlayer(Vector3 direction)
    {
        //rb.velocity = direction * speed;
        //rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
        rb.AddForce(direction * speed);
    }
}
