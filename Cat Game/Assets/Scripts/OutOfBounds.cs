using UnityEngine;
public class OutOfBounds : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        print("Triggered");
        if (other.gameObject.tag == "Mouse")
        {
            Destroy(other.gameObject);
        }
    }
}
