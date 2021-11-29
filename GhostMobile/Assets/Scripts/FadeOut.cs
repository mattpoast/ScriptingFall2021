using UnityEngine;
public class FadeOut : MonoBehaviour
{
    public Animator fadeOutAnimator;
    public void Start()
    {
        fadeOutAnimator = GetComponent<Animator>();
    }
    public void Update()
    {
        if (VaccumAi.fadeOut)
        {
           fadeOutAnimator.SetTrigger("Out");
        }
        if (Coffin.wonGame)
        {
            fadeOutAnimator.SetTrigger("Out");
        }
    }
}
