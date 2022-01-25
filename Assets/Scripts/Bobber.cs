using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobber : MonoBehaviour
{
    public float speed = 0.3f;
    private float yMax = 1f;
    private float yMin = 0.5f;
    private int direction = 1;

    // Update is called once per frame
    void Update()
    {
        float yNew = transform.position.y + direction * speed * Time.deltaTime;

        if (yNew >= yMax)
        {
            yNew = yMax;
            direction *= -1;
        }
        else if (yNew <= yMin)
        {
            yNew = yMin;
            direction *= -1;
        }
        transform.position = new Vector3(transform.position.x, yNew, transform.position.z);
    }
}
