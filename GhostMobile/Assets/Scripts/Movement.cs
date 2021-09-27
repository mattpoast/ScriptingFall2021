using UnityEngine;
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 3f;
    
    void Update()
    {
        Vector3 move = new Vector3(Input.touchCount, 0, Input.touchCount);
        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}
