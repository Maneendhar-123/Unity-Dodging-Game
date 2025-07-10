using UnityEngine;

public class TriggerCollision : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles = new GameObject[5];

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < 5; i++)
            { 
                projectiles[i].SetActive(true);
            }
        }
    }
}
