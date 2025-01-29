using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    private bool canJump = false;

    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();

    public void setCanJump(bool setter)
    {
        this.canJump = setter;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            setCanJump(true);
            //Debug.Log("Set canJump to True");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            setCanJump(false);
            //Debug.Log("Set canJump to False");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = Vector3.zero; // initialize input vector
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("User's Input: W");
            inputVector += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("User's Input: A");
            inputVector += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("User's Input: S");
            inputVector += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("User's Input: D");
            inputVector += Vector3.right;
        }
        if (Input.GetKey(KeyCode.Space) && canJump == true)
        {
            //Debug.Log("User's Input: Spacebar");
            inputVector += Vector3.up;
            this.canJump = false;
        }

        OnMove?.Invoke(inputVector);
    }
}
