using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{

    public Transform target;
    NavMeshAgent agent;
    bool done = false;
    Vector3 desPos;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //if ((target.position.x -2 < agent.transform.position.x) | (agent.transform.position.x < target.position.x +2) & !(target.position.z -2 < agent.transform.position.z) | !(agent.transform.position.z < target.position.z +2) & !done)
        if((Mathf.Abs(Mathf.Abs(target.position.x) - Mathf.Abs(agent.transform.position.x)) <2) & (Mathf.Abs(Mathf.Abs(target.position.z) - Mathf.Abs(agent.transform.position.z)) <2))
        {
            //done = false;
            agent.SetDestination(agent.transform.position);
           // if (desPos != target.position)
            //{
               // done = false;
           // }
            
        } else
        {
            //Debug.Log(target.position);
            agent.SetDestination(target.position);
            //desPos = target.position;
        }
        
    }
}
