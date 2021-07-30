using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ResourceCount : MonoBehaviour
{

    public Text text;

    public int count = 0;
    //int delay = 1;
    //float timer;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Water: " + 0;
    }

    // Update is called once per frame
    void Update()
    {
      /*  timer += Time.deltaTime;
        if (timer >= delay )
        {
            timer = 0f;
            if (count < 1000)
            {
                count++;
                text.text = "Water " + count;
            }
        }*/
    }

}
