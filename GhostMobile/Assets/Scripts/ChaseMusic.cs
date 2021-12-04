using UnityEngine;
public class ChaseMusic : MonoBehaviour
{
    public GameObject gameMusic;
    public GameObject chaseAudioObject;
    public GameObject menuMusic;
    public float distance;
    public GameObject vacuum;
    public float chased = 10f;
    public Vector3 vacuumLocation;
    public void Start()
    {
        gameMusic.SetActive(true);
        chaseAudioObject.SetActive(false);
        menuMusic.SetActive(false);
    }
    public void FixedUpdate()
    {
        vacuumLocation = vacuum.transform.position;
        Vector3 distanceVector = transform.position - vacuumLocation;
        distance = distanceVector.magnitude;
        if (distance <= chased)
        {
            gameMusic.SetActive(false);
            chaseAudioObject.SetActive(true);
        }
        else
        {
            gameMusic.SetActive(true);
            chaseAudioObject.SetActive(false);
        }
    }
}
