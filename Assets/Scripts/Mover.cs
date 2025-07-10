using UnityEngine;

public class Mover : MonoBehaviour
{
    void Start()
    {
        PrintInstruction();
    }

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpHeight = 10f;
    [SerializeField] int timer = 0;
    [SerializeField] int xTime = 0;

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        timer = timer + 1;
        float yValue;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        if (xTime == 0)
        {
            // yValue = Input.GetAxis("Jump") * Time.deltaTime * moveSpeed * jumpHeight;
            yValue = Input.GetAxis("Jump") * jumpHeight;
            transform.Translate(xValue, yValue, zValue);
            if (yValue != 0)
            {
                xTime = 1;
                timer = 1;
            }
        }
        else if (xTime == 1 && timer % 100 != 0)
        {
            yValue = 0f;
            transform.Translate(xValue, yValue, zValue);
            ChangeTimer(timer);
        }
        else if (timer % 100 == 0 && xTime == 1)
        {
            xTime = 0;
        }
    }

    void ChangeTimer(int timer)
    {
        timer = timer + 1;
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("Play using the arrows or wasd keys");
        Debug.Log("Do not collide with the obstacles");
    }
}
