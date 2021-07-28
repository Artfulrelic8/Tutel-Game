using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavDestination : MonoBehaviour
{

    public Camera cam;
    public GameObject ground;
    public Transform Destination;
    Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 1000))
            {
                vec = hit.point;
                Destination.transform.position = vec;
            }
        }
    }
}
