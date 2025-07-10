using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Untagged")
        {
            hits++;
            Debug.Log("Your score is: " + hits);
        }
    }
}
