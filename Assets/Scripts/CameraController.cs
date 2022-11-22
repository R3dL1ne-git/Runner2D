using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public PlayerController player;

    //Vector3 lastPosition;
    //float distanseToMove;

    //void Start()
    //{
    //    player = FindObjectOfType<PlayerController>();
    //    lastPosition = player.transform.position;
    //}

    //void Update()
    //{
    //    distanseToMove = player.transform.position.x - lastPosition.x;

    //    transform.position = new Vector3(transform.position.x + distanseToMove, transform.position.y, transform.position.z);

    //    lastPosition = player.transform.position;
    //}

    public Transform player;
    public float movingSpeed;

    private void Awake()
    {
        if (player == null)
        {
            player = GameObject.Find("Player").transform;
        }

        transform.position = new Vector3()
        {
            x = player.position.x,
            y = player.position.y,
            z = player.position.z - 10
        };
    }

    private void Update()
    {
        if (player)
        {
            Vector3 target = new Vector3()
            {
                x = player.position.x,
                y = player.position.y,
                z = player.position.z - 10
            };

            Vector3 pos = Vector3.Lerp(transform.position, target, movingSpeed * Time.deltaTime);
            transform.position = pos;
        }
    }
}
