using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionnegativa : MonoBehaviour
{
    public float speed = 0.5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * -360 * speed);
    }
}
