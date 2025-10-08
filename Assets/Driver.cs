using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.01f;

    float steer, move = 0f;

    void Update()
    {

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;

        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            steer = 0.01f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -0.01f;
        }

        transform.Rotate(0, 0, steer * steerSpeed);
        transform.Translate(0, move * moveSpeed, 0);
        
        
    }
}
