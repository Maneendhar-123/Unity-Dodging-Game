using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float movingSpeed = 100f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Start()
    {
        gameObject.SetActive(false);
        playerPosition = player.transform.position;
    }

    void Update()
    {
        float speed = movingSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed);
        if (transform.position == playerPosition)
        {
            DestroyWhenReached();
        }
    }

    void DestroyWhenReached()
    {
        gameObject.SetActive(false);
    }
}
