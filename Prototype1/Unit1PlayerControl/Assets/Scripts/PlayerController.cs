using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Movement tuning (editable in inspector)
    public float speed = 5.0f;
    public float turnSpeed;
    // Input System Action exposed in inspector for binding (WASD/Arrow Keys)
    public InputAction moveAction;
   
    //Current Input Value (x = left/right, y = forwrd/back), kept private for internal use
    private Vector2 moveInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Enable the MoveActin so it starts reading input
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //Read the 2D vector from the Moveaction (x: horizontal, y: vertical)
        moveInput = moveAction.ReadValue<Vector2>();

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
       
        // move the vechile left/right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
     
    }
}
