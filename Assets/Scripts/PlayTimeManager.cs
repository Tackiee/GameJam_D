using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayTimeManager : MonoBehaviour
{
    public CountDown countDown;
    public Text TimerText;

    float timer = 10.0f;
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
        if (checker && !GameFinish)
        {
            TimerText.text = timer.ToString();
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
