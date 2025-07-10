using UnityEngine;

public class Spinning : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 1f;
    [SerializeField] float zAngle = 0f;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
