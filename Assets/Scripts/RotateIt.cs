using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class RotateIt: MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    void Start()
    { 
    }

    void Update()
    {
        transform.Rotate(_rotation * 1f * Time.deltaTime);
    }
}
