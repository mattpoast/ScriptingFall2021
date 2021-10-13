using UnityEngine;
public class KeySpawner : MonoBehaviour
{
    public GameObject keyOne, keyTwo, keyThree;
    public int spawnNumber;
    void Start()
    {
        KeySpawn();
    }
    public void KeySpawn()
    {
        spawnNumber = Random.Range(0, 3);
        if (spawnNumber == 0)
        {
            Instantiate(keyOne);
        }
    }
}
