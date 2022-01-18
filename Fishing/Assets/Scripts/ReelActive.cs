using UnityEngine;
public class ReelActive : MonoBehaviour
{
    public GameObject reel;
    public bool fishOn;
    public Animator reelAnimator;
    public void FishOn()
    {
        if (fishOn)
        {
           print("FishOn");
            reel.SetActive(true);
        }
        else
        {
            print("FishOff");
            reel.SetActive(false);
        }
    }
}
