using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildUnit : MonoBehaviour
{

    public Camera cam;
    public GameObject ground;
    public Transform Destination;
    public GameObject Villager;
    public GameObject TCSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var rayL = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitL;
            if (Physics.Raycast(rayL, out hitL, 1000))
            {
                if (hitL.collider.tag == "Town Center")
                {
                  GameObject GO = Instantiate(Villager, TCSpawn.transform.position, Quaternion.identity);
                    GO.GetComponent<NavDestination>().cam = cam;
                    GO.GetComponent<NavDestination>().ground = ground;
                    GO.GetComponent<NavDestination>().Destination = Destination;
                }
            }
        }
    }
}
