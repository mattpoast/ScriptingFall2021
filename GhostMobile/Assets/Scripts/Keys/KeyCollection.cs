using UnityEngine;
using UnityEngine.UI;
public class KeyCollection : MonoBehaviour
{
    public Image key1Color, key2Color, key3Color;
    public GameObject keyAudioOne, keyAudioTwo, keyAudioThree;
    public void Start()
    {
        keyAudioOne.SetActive(false);
        keyAudioTwo.SetActive(false);
        keyAudioThree.SetActive(false);
        key1Color.enabled = false;
        key2Color.enabled = false;
        key3Color.enabled = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ghost")
        {
            KeyList.keyCount += 1;
            if (KeyList.keyCount == 1)
            {
                key1Color.enabled = true;
                keyAudioOne.SetActive(true);
            }
            if (KeyList.keyCount == 2)
            {
                key2Color.enabled = true;
                keyAudioTwo.SetActive(true);
            }
            if (KeyList.keyCount == 3)
            {
                key3Color.enabled = true;
                keyAudioThree.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
