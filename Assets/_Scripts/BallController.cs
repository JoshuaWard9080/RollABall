using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidBody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float jumpSpeed = 100f;
    
    public void MoveBall(Vector3 input)
    {
        sphereRigidBody.AddForce(input.x * ballSpeed, input.y * jumpSpeed, input.z * ballSpeed);
    }
}
