using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float timer;
    int delay = 1;
    public int avgFrameRate;
    public Text display_Text;

    public void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay) {
            timer = 0f;
            float current = 0;
            current = (int)(1f / Time.unscaledDeltaTime);
            avgFrameRate = (int)current;
            display_Text.text = avgFrameRate.ToString() + " FPS";
        }
    }
}
