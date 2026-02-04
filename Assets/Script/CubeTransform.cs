using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransform : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float rotateSpeed = 20.0f;
    public float scaleSpeed = 0.5f;
  
    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        float newSize = Mathf.PingPong(Time.time * scaleSpeed, 2.0f) + 0.5f;
        transform.localScale = new Vector3(newSize, newSize, newSize);
        
    }
}
