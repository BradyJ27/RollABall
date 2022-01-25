using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed = 5.0f;
    public float zMax = 7.5f;
    public float zMin = -7.5f;
    private int direction = 1;

    void Start()
    {
        zMax += transform.position.z;
        zMin += transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        float zNew = transform.position.z + direction * speed * Time.deltaTime;

        if(zNew >= zMax)
		{
            zNew = zMax;
            direction *= -1;
		} else if (zNew <= zMin)
		{
            zNew = zMin;
            direction *= -1;
		}
        transform.position = new Vector3( transform.position.x, 0.75f, zNew);
    }
}
