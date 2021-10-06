using UnityEngine;
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 3f;
    
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        controller.Move(move * Time.deltaTime * moveSpeed);
    }
}
