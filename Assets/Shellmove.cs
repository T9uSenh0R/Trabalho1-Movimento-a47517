using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shellmove : MonoBehaviour
{
    float speed = 1;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate((speed * Time.deltaTime)/2.0f, speed * Time.deltaTime, speed * Time.deltaTime);
    }
}
