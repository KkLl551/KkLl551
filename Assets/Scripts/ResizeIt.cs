using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ResizePerSecond());    
    }

    void Update()
    {
        
    }

    IEnumerator ResizePerSecond()
    {
        while(true)
        {
            for(int i = 1; i < 5; i++)
            {
                yield return new WaitForSeconds(1f);
                transform.localScale = new Vector3(i, i, i);
            }
        }    
    }
}
