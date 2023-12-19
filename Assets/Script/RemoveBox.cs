using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBox : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 3f);
    }
}
