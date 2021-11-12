using UnityEngine;
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 3f;
    public float gravity;
    public Joystick joyStick;
    public float smoothTurn = 0.3f;
    private float smoothTurnVelocity;
    void Update()
    {
        Vector3 move = new Vector3(joyStick.Horizontal, gravity, joyStick.Vertical).normalized;
        if (move.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothTurnVelocity, smoothTurn);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            controller.Move(move * Time.deltaTime * moveSpeed);
        }
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
