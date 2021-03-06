using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUnit : MonoBehaviour
{

    public Camera cam;
    public GameObject ground;
    public Transform Destination;
    public GameObject Villager;
    public GameObject TCSpawn;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    
    public void spawnVillager()
    {
        GameObject GO = Instantiate(Villager, TCSpawn.transform.position, Quaternion.identity);
        GO.GetComponent<NavDestination>().cam = cam;
        GO.GetComponent<NavDestination>().ground = ground;
        GO.GetComponent<NavDestination>().Destination = Destination;
    }
}
