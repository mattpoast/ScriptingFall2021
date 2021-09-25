using UnityEngine;
public class MobileDragMovement : MonoBehaviour
{
    public float speed = 0.3f;
    public Vector3 touchPosition;
    public Animator animator;
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchPosition = Input.GetTouch(0).deltaPosition;
            //transform.Translate(touchPosition.x * speed * Time.deltaTime, 0, touchPosition.z * speed * Time.deltaTime);
            Camera.main.ScreenToWorldPoint(touchPosition * speed * Time.deltaTime);
            transform.Translate(touchPosition);
        }
    }
}
