using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yValue = 0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,yValue,0f);
    }
}
