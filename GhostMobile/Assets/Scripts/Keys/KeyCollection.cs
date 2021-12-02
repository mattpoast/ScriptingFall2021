using UnityEngine;
using UnityEngine.UI;
public class KeyCollection : MonoBehaviour
{
    public Image key1Color, key2Color, key3Color;
    public AudioClip keyPickUp;
    private Vector3 audioLocation;
    public void Start()
    {
        key1Color.enabled = false;
        key2Color.enabled = false;
        key3Color.enabled = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ghost")
        {
            AudioSource.PlayClipAtPoint(keyPickUp,audioLocation,10);
            KeyList.keyCount += 1;
            if (KeyList.keyCount == 1)
            {
                key1Color.enabled = true;
            }
            if (KeyList.keyCount == 2)
            {
                key2Color.enabled = true;
            }
            if (KeyList.keyCount == 3)
            {
                key3Color.enabled = true;
            }
            Destroy(gameObject);
        }
    }
}
