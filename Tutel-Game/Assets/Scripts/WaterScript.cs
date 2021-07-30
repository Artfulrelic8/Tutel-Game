using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] assignedV = new GameObject[5];

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addVillager(GameObject villager)
    {
        if(this.isFull() == -1)
        {
            Debug.Log("There are enough Villagers working there already!");
        }
        else
        {
            this.assignedV[this.isFull()] = villager;
        }
    }

    int isFull()
    {
        for(int i = 0; i < assignedV.Length; i++)
        {
            if(assignedV[i] == null)
            {
                return i;
            }
        }
        return -1;
    }
}
