using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    Vector3 minScale;
    public Vector3 maxScale;
    float speed = 1f;
    float duration = 4f;
    IEnumerator Start()
    {
        minScale = transform.localScale;
        while(true)
        {
            yield return Resize(minScale, maxScale, duration);
            transform.localScale = minScale;
        }
    }

    public IEnumerator Resize(Vector3 a, Vector3 b, float time)
    {
        float i = 0f;
        float rate = (1.0f / time) * speed;
        while (i < 1f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }  
    }
}
