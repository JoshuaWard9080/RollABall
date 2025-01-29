using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Calling the Update method");


        Vector2 inputVector = Vector2.zero; // initialize input vector
        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("User's Input: W");
            inputVector += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A)){
            Debug.Log("User's Input: A");
            inputVector += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S)){
            Debug.Log("User's Input: S");
            inputVector += Vector2.down;
        }
        if (Input.GetKey(KeyCode.D)){
            Debug.Log("User's Input: D");
            inputVector += Vector2.right;
        }

        Debug.Log("Resultant Vector: " + inputVector);
    }
}
