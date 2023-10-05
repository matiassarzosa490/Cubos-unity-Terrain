
using UnityEngine;

public class MoveAndRotateObject : MonoBehaviour
{
    [Header("Move/Rotate")]
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotationSpeed;

    private Vector3 rotationVector;

    void Update()
    {
        MoveCamera();
        RotateCamera();
    }

    void MoveCamera()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(inputX, 0, inputZ);
        Vector3 moveAmount = moveDirection * moveSpeed;

        transform.Translate(moveAmount);
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotationVector.x -= mouseY * rotationSpeed;
        rotationVector.y += mouseX * rotationSpeed;

        transform.eulerAngles = rotationVector;
    }
}