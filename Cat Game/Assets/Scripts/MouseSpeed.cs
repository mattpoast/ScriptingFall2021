using UnityEngine;
public class MouseSpeed : MonoBehaviour
{
    public static float mouseSpeedValue;

    public void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, MouseGenerator.mouseRotation);
    }

    void Update()
    { 
        transform.Translate(Vector3.up * Time.deltaTime * mouseSpeedValue);
    }
}
