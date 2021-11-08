using UnityEngine;
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 3f;
    public float gravity;
    public Joystick joyStick;
    void Update()
    {
        Vector3 move = new Vector3(joyStick.Horizontal, gravity, joyStick.Vertical);
        controller.Move(move * Time.deltaTime * moveSpeed);
        move.Normalize();
        if (controller.isGrounded)
        {
            gravity = 0f;
        }
        else
        {
            gravity -= 9.81f * Time.deltaTime;
        }
    }
}
