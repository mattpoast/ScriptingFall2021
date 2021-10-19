using UnityEngine;
public class KeySpawner : MonoBehaviour
{
    public GameObject keyOne, keyTwo, keyThree;
    public int spawnNumberOne;
    public int spawnNumberTwo;
    public int spawnNumberThree;
    public Vector3 optionOne;
    public Vector3 optionTwo;
    public Vector3 optionThree;
    public Vector3 optionTwoOne;
    public Vector3 optionTwoTwo;
    public Vector3 optionTwoThree;
    public Vector3 optionThreeOne;
    public Vector3 optionThreeTwo;
    public Vector3 optionThreeThree;
    void Start()
    {
        KeySpawn();
    }
    public void KeySpawn()
    {
        spawnNumberOne = Random.Range(0, 3);
        if (spawnNumberOne == 0)
        {
            keyOne.transform.position = optionOne;
        }
        if (spawnNumberOne == 1)
        {
            keyOne.transform.position = optionTwo;
        }
        if (spawnNumberOne == 2)
        {
            keyOne.transform.position = optionThree;
        }
        spawnNumberTwo = Random.Range(0, 3);
        if (spawnNumberTwo == 0)
        {
            keyTwo.transform.position = optionTwoOne;
        }
        if (spawnNumberTwo == 1)
        {
            keyTwo.transform.position = optionTwoTwo;
        }
        if (spawnNumberTwo == 2)
        {
            keyTwo.transform.position = optionTwoThree;
        }
        spawnNumberThree = Random.Range(0, 3);
        if (spawnNumberThree == 0)
        {
            keyThree.transform.position = optionThreeOne;
        }
        if (spawnNumberThree == 1)
        {
            keyThree.transform.position = optionThreeTwo;
        }
        if (spawnNumberThree == 2)
        {
            keyThree.transform.position = optionThreeThree;
        }
    }
}
