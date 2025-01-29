using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidBody;
    [SerializeField] private float ballSpeed = 2f;
    
    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed);
    }
}
