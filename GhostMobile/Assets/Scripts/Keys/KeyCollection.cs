using UnityEngine;
public class KeyCollection : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        KeyList.keyCount += 1;
        print(KeyList.keyCount);
        Destroy(gameObject);
    }
}
