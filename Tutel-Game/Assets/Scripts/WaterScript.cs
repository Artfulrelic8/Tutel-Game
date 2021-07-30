using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] assignedV = new GameObject[5];
    public Text WaterCounter;
    float timer;
    int delay = 1;
    //int counter = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int a = this.numV();
        int b = WaterCounter.GetComponent<ResourceCount>().count;
        //int b = WaterCounter.GetComponent<ResourceCount>().count;
        Debug.Log(a + " " + b);
        timer += Time.deltaTime;
        if (timer >= delay)
        {
            timer = 0f;
            if (a + b >= 1000)
            {
                WaterCounter.GetComponent<ResourceCount>().text.text = "Water: " + (1000 + 0);
            }
            else
            {
                WaterCounter.GetComponent<ResourceCount>().text.text = "Water: " + (a + b);
                WaterCounter.GetComponent<ResourceCount>().count = WaterCounter.GetComponent<ResourceCount>().count + a;
                //counter = counter + a;
            }
        }
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
            //this.villager.isSelected = true;
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

    int numV()
    {
        int c = 0;
        for(int i = 0; i < assignedV.Length; i++)
        {
            if(assignedV[i] != null)
            {
                c++;
            }
        }
        return c;
    }
}
