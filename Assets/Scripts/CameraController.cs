using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController player;

    Vector3 lastPosition;
    float distanseToMove;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        lastPosition = player.transform.position;
    }

    void Update()
    {
        distanseToMove = player.transform.position.x - lastPosition.x;

        transform.position = new Vector3(transform.position.x + distanseToMove, transform.position.y, transform.position.z);

        lastPosition = player.transform.position;
    }
}
