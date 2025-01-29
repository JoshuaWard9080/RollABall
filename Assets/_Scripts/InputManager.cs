using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; // initialize input vector
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("User's Input: W");
            inputVector += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("User's Input: A");
            inputVector += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("User's Input: S");
            inputVector += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("User's Input: D");
            inputVector += Vector2.right;
        }

        OnMove?.Invoke(inputVector);
    }
}
