using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    public float speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        //Move GameObject backward
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}