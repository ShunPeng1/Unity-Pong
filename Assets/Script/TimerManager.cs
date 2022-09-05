using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text TimerText;

    public static float timer;
    public static bool timeStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        int minutes = 0;
        int seconds = 0;
        string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        TimerText.text = niceTime;

    }

    // Update is called once per frame
    

    void Update()
    {
        if (timeStarted == true)
        {
            timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(timer / 60F);
            int seconds = Mathf.FloorToInt(timer - minutes * 60);
            string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            TimerText.text = niceTime;
        }
    }
    
}
