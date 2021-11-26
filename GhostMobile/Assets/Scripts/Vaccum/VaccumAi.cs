using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class VaccumAi : MonoBehaviour
{
    public float vacuumSpeed = 6f;
    public NavMeshAgent vaccum;
    public GameObject ghost;
    public int vacuumDestination;
    public Vector3 patrolZero, patrolOne, patrolTwo, patrolThree;
    public float distance;
    public float gameOverDistance = 3f;
    public Vector3 ghostLocation;
    public float ghostChase = 15f;
    public float slowVacuumSpeed = 2.9f;
    public static bool fadeOut;
    public void Start()
    {
        NewLocation();
        vaccum.speed = vacuumSpeed;
    }
    private void NewLocation()
    {
        vacuumDestination = Random.Range(0, 4);
    }
    void Update()
    { 
        ghostLocation = ghost.transform.position;
        Vector3 distanceVector = transform.position - ghostLocation;
        distance = distanceVector.magnitude;
        if (distance <= gameOverDistance)
        {
            fadeOut = true;
            Invoke("LoadNewSceen",2f);
            vaccum.speed = .01f;
        }
        switch (vacuumDestination)
        {
            case 0: vaccum.destination = patrolZero;
                if (Vector3.Distance(transform.position, patrolZero) < 3.5f)
                {
                    NewLocation();
                }
                if (distance <= ghostChase)
                {
                    vaccum.speed = slowVacuumSpeed;
                    vaccum.destination = ghostLocation;
                    if (distance >= ghostChase)
                    {
                        vaccum.speed = vacuumSpeed;
                        NewLocation();
                    }
                }
                break;
            case 1: vaccum.destination = patrolOne;
                if (Vector3.Distance(transform.position, patrolOne) < 3.5f)
                {
                    NewLocation();
                }
                if (distance <= ghostChase)
                {
                    vaccum.speed = slowVacuumSpeed;
                    vaccum.destination = ghostLocation;
                    if (distance >= ghostChase)
                    {
                        vaccum.speed = vacuumSpeed;
                        NewLocation();
                    }
                }
                break;
            case 2: vaccum.destination = patrolTwo;
                if (Vector3.Distance(transform.position, patrolTwo) < 3.5f)
                {
                    NewLocation();
                }
                if (distance <= ghostChase)
                {
                    vaccum.speed = slowVacuumSpeed;
                    vaccum.destination = ghostLocation;
                    if (distance >= ghostChase)
                    {
                        vaccum.speed = vacuumSpeed;
                        NewLocation();
                    }
                }
                break;
            case 3: vaccum.destination = patrolThree;
                if (Vector3.Distance(transform.position, patrolThree) < 3.5f)
                {
                    NewLocation();
                }
                if (distance <= ghostChase)
                {
                    vaccum.speed = slowVacuumSpeed;
                    vaccum.destination = ghostLocation;
                    if (distance >= ghostChase)
                    {
                        vaccum.speed = vacuumSpeed;
                        NewLocation();
                    }
                }
                break;
        }
    }
    void LoadNewSceen()
    {
        SceneManager.LoadScene(2);
    }
}
