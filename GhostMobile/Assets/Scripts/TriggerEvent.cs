using UnityEngine;
using UnityEngine.Events;
public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
