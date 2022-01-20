using UnityEngine;
public class BoatMover : MonoBehaviour
{
  public CharacterController controller;
  public float boatSpeed = 3.5f;
  public Joystick joyStick;
  public float smoothTurn = 500f;
  private float smoothTurnVelocity;
  public void Update()
  {
    Vector3 move = new Vector3(joyStick.Horizontal, 0, joyStick.Vertical).normalized;
    if (move.magnitude >= 0.1f)
    {
      float tartgetAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg;
      float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, tartgetAngle, ref smoothTurnVelocity, smoothTurn);
      transform.rotation = Quaternion.Euler(0f,angle,0f);
      controller.Move(move * Time.deltaTime * boatSpeed);
    }
  }
}
