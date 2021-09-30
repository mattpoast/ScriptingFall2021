using UnityEngine;
public class Pause : MonoBehaviour
{
    public void onButtonTap()
    {
        Time.timeScale = 0f;
    }
}