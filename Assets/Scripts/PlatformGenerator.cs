using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform;
    public Transform generationPoint;
    public float distanseBetween;

    float platformWidth;

    void Start()
    {
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
    }

    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWidth + distanseBetween, transform.position.y, transform.position.z);

            Instantiate(platform, transform.position, transform.rotation);
        }
    }
}
