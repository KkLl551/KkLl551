using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    void Start()
    { 
        Vector3 move = new Vector3(5.5f, 8.5f, -12);
        transform.position = move;
        transform.Rotate(30, -25, 0);
    }

    void Update()
    {
        Vector3 moveDir = new Vector3(0, 0, 0);
        if(Input.GetKey(KeyCode.W))
        {
            moveDir.z = +1f;
        }
        if(Input.GetKey(KeyCode.S))
        {
             moveDir.z = -1f;
        }

        float moveSpeed = 0.5f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
}
