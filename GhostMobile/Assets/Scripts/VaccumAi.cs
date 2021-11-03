using UnityEngine;
using UnityEngine.AI;
public class VaccumAi : MonoBehaviour
{
    public NavMeshAgent vaccum;
    public GameObject ghost;
    public void Start()
    {
       ghost = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        vaccum.destination = ghost.transform.position;
    }
}
