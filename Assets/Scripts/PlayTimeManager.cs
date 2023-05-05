using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayTimeManager : MonoBehaviour
{
    public CountDown countDown;
    public Text TimerText;

    public player py;
    public static int count;

    public float timer = 60.0f;
    float stay = 2.0f;
    bool checker;
    bool GameFinish = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(timer);
        checker = countDown.startChecker;
        count = py.GetCount;
        if (checker && !GameFinish)
        {
            TimerText.text = timer.ToString("f0");
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                GameFinish = true;
                timer = 0.0f;
            }
        }
        
        if(GameFinish)
        {
            stay -= Time.deltaTime;
            TimerText.text = "I—¹I";
            if(stay < 0)
            {
                SceneManager.LoadScene("End_Scene");
            }
        }
    }


}
