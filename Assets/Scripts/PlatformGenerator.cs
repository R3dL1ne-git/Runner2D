using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platform;
    public Transform generationPoint;
    public float distanseBetween;
    public float distanseMin;
    public float distanseMax;

    float platformWidth;

    public PlatformManager platformM;

    void Start()
    {
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
    }

    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            distanseBetween = Random.Range(distanseMin, distanseMax);

            transform.position = new Vector3(transform.position.x + platformWidth + distanseBetween, transform.position.y, transform.position.z);

            //Instantiate(platform, transform.position, transform.rotation);

            GameObject newPlatform = platformM.GetPlatform();
            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);
        }
    }
}
