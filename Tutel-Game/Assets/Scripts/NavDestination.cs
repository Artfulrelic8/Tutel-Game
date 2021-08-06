using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavDestination : MonoBehaviour
{

    public Camera cam;
    public GameObject ground;
    public Transform Destination;
    NavMeshAgent agent;
    public GameObject workstation;
    Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var rayR = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitR;
            if(Physics.Raycast(rayR, out hitR, 1000) && hitR.collider.tag == "Ground")
            {
                vec = hitR.point;
                Destination.transform.position = vec;
                move();
            }
        }
    }

    public void move()
    {
        agent.SetDestination(Destination.transform.position);
    }
}
