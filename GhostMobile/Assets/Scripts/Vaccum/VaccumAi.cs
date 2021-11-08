using UnityEngine;
using UnityEngine.AI;
public class VaccumAi : MonoBehaviour
{
    public float vacuumSpeed = 6f;
    public NavMeshAgent vaccum;
    public GameObject ghost;
    public int vacuumDestination;
    public Vector3 patrolZero, patrolOne, patrolTwo, patrolThree;
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
        switch (vacuumDestination)
        {
            case 0: vaccum.destination = patrolZero;
                if (Vector3.Distance(transform.position, patrolZero) < 3.5f)
                {
                    NewLocation();
                    print("working");
                }
                break;
            case 1: vaccum.destination = patrolOne;
                if (Vector3.Distance(transform.position, patrolOne) < 3.5f)
                {
                    NewLocation();
                    print("working1");
                }
                break;
            case 2: vaccum.destination = patrolTwo;
                if (Vector3.Distance(transform.position, patrolTwo) < 3.5f)
                {
                    NewLocation();
                    print("working2");
                }
                break;
            case 3: vaccum.destination = patrolThree;
                if (Vector3.Distance(transform.position, patrolThree) < 3.5f)
                {
                    NewLocation();
                    print("working3");
                }
                break;
        }
    }
}
