using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isWalking;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private GameInput gameInput;

    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        transform.position += moveDir * moveSpeed * Time.deltaTime;

        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);

        isWalking = moveDir != Vector3.zero;
    }

    public bool IsWalking(){
        return isWalking;
    }

}
