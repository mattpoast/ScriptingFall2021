using UnityEngine;
public class FishOn : MonoBehaviour
{
    public GameObject reel;
    public bool fishOn;
    public void Start()
    {
        CheckFish();
    }
    private void OnMouseDown()
    {
        fishOn = true;
        CheckFish();
    }
    public void CheckFish()
    {
        if (fishOn)
        {
            reel.SetActive(true);
        }
        else
        {
            reel.SetActive(false);
        }
    }
}
