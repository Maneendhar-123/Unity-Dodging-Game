using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTime = 3;
    int varDrop = 0;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > dropTime && varDrop == 0)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
            varDrop = 1;
            // Debug.Log("Lookout for the Droppers");
        }
    }
}
