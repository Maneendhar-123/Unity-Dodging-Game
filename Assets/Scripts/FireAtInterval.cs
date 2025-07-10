using Unity.VisualScripting;
using UnityEngine;

public class FireAtInterval : MonoBehaviour
{
    [SerializeField] float fireSpeed = 10f;
    [SerializeField] GameObject[] fires = new GameObject[10];
    [SerializeField] GameObject player;
    Vector3 playerPosition;
    int[] alreadyFired = new int[10];
    void Start()
    {
        initialiseFiring();
        playerPosition = player.transform.position;
    }

    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            if (Time.time > 2 * i && alreadyFired[i] == 0)
            {
                fires[i].transform.position = Vector3.MoveTowards(fires[i].transform.position, playerPosition, fireSpeed * Time.deltaTime);
                if (fires[i].transform.position == playerPosition)
                {
                    fires[i].SetActive(false);
                    alreadyFired[i] = 1;
                }
            }
        }
        playerPosition = player.transform.position;
    }

    void initialiseFiring()
    {
        for (int i = 0; i < 10; i++)
        {
            alreadyFired[i] = 0;
        }
    }
}
