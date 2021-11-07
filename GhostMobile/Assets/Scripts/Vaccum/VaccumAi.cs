using UnityEngine;
using UnityEngine.AI;
public class VaccumAi : MonoBehaviour
{
    public NavMeshAgent vaccum;
    public GameObject ghost;
    void Update()
    {
        vaccum.destination = ghost.transform.position;
    }
}
